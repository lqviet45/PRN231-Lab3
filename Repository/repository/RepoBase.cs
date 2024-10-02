using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repository.abstraction.repository;
using Repository.entities;

namespace Repository.repository;

public class RepoBase<TEntity, TKey> : IRepoBase<TEntity, TKey> 
    where TEntity : Entity
    where TKey : struct
{
    private readonly MyDbContext _context;

    public RepoBase(MyDbContext context)
    {
        _context = context;
    }

    public IQueryable<TEntity> GetAll()
    {
        return _context.Set<TEntity>();
    }

    public async Task<(int page, int totalItems, List<TEntity>)> GetWithConditionAsync(
        int page = 1,
        int pageSize = 100,
        Expression<Func<TEntity, bool>>? expression = null,
        Expression<Func<TEntity, object>>? orderBy = null,
        string? sortOrder = null,
        params Expression<Func<TEntity, object?>>[] includes)
    {
        var query = _context.Set<TEntity>().AsQueryable();
        if (expression != null)
        {
            query = query.Where(expression);
        }

        if (includes.Length > 0)
        {
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }
        
        if (orderBy != null)
        {
            query = sortOrder switch
            {
                "Asc" => query.OrderBy(orderBy),
                "Desc" => query.OrderByDescending(orderBy),
                _ => query
            };
        }

        var totalItems = await query.CountAsync();
        var items = await query.Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        
        return (page, totalItems, items);
    }

    public async Task<TEntity?> GetByIdAsync(TKey id, params Expression<Func<TEntity, object?>>[] includes)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>().AsQueryable();
        if (includes.Length > 0)
        {
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }
        
        return await query.FirstOrDefaultAsync(x => x.Id.Equals(id));
    }

    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }
}