namespace Repository.abstraction;

public interface IUnitOfWork
{
    Task<bool> SaveChangesAsync();
}