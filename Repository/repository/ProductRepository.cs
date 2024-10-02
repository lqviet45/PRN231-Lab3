using Repository.abstraction.repository;
using Repository.entities;

namespace Repository.repository;

public class ProductRepository : RepoBase<Product, int>, IProductRepository
{
    public ProductRepository(MyDbContext context) : base(context)
    {
    }
}