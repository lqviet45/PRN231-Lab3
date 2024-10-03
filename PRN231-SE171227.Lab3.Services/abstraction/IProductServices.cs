using Repository.entities;
using Services.BusinessObject;
using Services.Enums;

namespace Services.abstraction;

public interface IProductServices
{
    Task<PagedResponse<ProductResponse>> GetAllProducts(string? search = null,
        SearchBy searchBy = SearchBy.Name,
        string? filter = null,
        string? filterOperator = null,
        FilterBy filterBy = FilterBy.UnitPrice,
        int page = 1,
        int pageSize = 10,
        SortBy sortBy = SortBy.ProductName,
        SortOrder sortOrder = SortOrder.Asc);
    Task<Response.ProductDetailResponse?> GetProductById(int id);
    Task<Product> AddProduct(Product product);
    Task<bool> UpdateProduct(Product product);
    Task<bool> DeleteProduct(int id);
}