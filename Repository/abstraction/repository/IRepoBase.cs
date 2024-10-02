using System.Linq.Expressions;
using Repository.entities;

namespace Repository.abstraction.repository;

public interface IRepoBase<TEntity, in TKey> 
    where TEntity : Entity
    where TKey : struct
{
    IQueryable<TEntity> GetAll();
    
    Task<(int page, int totalItems, List<TEntity>)> GetWithConditionAsync(
        int page = 1,
        int pageSize = 100,
        Expression<Func<TEntity, bool>>? expression = null,
        Expression<Func<TEntity, object>>? orderBy = null,
        string? sortOrder = null,
        params Expression<Func<TEntity, object?>>[] includes);
    
    Task<TEntity?> GetByIdAsync(TKey id, params Expression<Func<TEntity, object?>>[] includes);
    
    void Add(TEntity entity);
    
    void Update(TEntity entity);
    
    void Delete(TEntity entity);
}