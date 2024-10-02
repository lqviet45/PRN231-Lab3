using Repository.abstraction;

namespace Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly MyDbContext _context;

    public UnitOfWork(MyDbContext context)
    {
        _context = context;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}