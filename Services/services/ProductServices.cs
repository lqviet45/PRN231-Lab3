using System.Globalization;
using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Repository.abstraction;
using Repository.abstraction.repository;
using Repository.entities;
using Services.abstraction;
using Services.BusinessObject;
using Services.Enums;

namespace Services.services;

public class ProductServices : IProductServices
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly int _defaultPageSize = 100;
    private readonly IMapper _mapper;
    
    public ProductServices(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PagedResponse<ProductResponse>> GetAllProducts(string? search = null, 
        SearchBy searchBy = SearchBy.Name,
        string? filter = null, string? filterOperator = null, FilterBy filterBy = FilterBy.UnitPrice, 
        int page = 1, int pageSize = 10,
        SortBy sortBy = SortBy.ProductName, SortOrder sortOrder = SortOrder.Asc)
    {
        if (pageSize > _defaultPageSize)
        {
            pageSize = _defaultPageSize;
        }

        Expression<Func<Product, bool>> expression = x => true;
        
        if (!string.IsNullOrWhiteSpace(search))
        {
            Expression<Func<Product, bool>> searchExpression = searchBy switch
            {
                SearchBy.Name => x => x.ProductName!.Contains(search),
                SearchBy.CategoryName => x => x.Category.CategoryName.Contains(search),
                _ => x => x.ProductName!.Contains(search)
            };
            
            expression = expression.And(searchExpression);
        }
        
        if (!string.IsNullOrWhiteSpace(filter))
        {
            Expression<Func<Product, bool>> filterExpression = filterBy switch
            {
                FilterBy.UnitPrice => filterOperator switch
                {
                    ">" => x => x.UnitPrice > decimal.Parse(filter, CultureInfo.InvariantCulture),
                    "<" => x => x.UnitPrice < decimal.Parse(filter, CultureInfo.InvariantCulture),
                    ">=" => x => x.UnitPrice >= decimal.Parse(filter, CultureInfo.InvariantCulture),
                    "<=" => x => x.UnitPrice <= decimal.Parse(filter, CultureInfo.InvariantCulture),
                    _ => x => x.UnitPrice >= decimal.Parse(filter, CultureInfo.InvariantCulture)
                },
                _ => x => x.UnitPrice == decimal.Parse(filter, CultureInfo.InvariantCulture)
            };
            
            expression = expression.And(filterExpression);
        }

        Expression<Func<Product, object>> orderBy = sortBy switch
        {
            SortBy.ProductName => x => x.ProductName,
            SortBy.CategoryName => x => x.Category.CategoryName,
            SortBy.UnitPrice => x => x.UnitPrice,
            _ => x => x.ProductName
        };

        var (_, totalItems, list) = await _productRepository
            .GetWithConditionAsync(page,
                pageSize,
                expression,
                orderBy,
                sortOrder.ToString()
            );
                
        var productResponse = _mapper.Map<List<Product>, List<ProductResponse>>(list);
        
        return new PagedResponse<ProductResponse>
        {
            Page = page,
            TotalItems = totalItems,
            PageSize = pageSize,
            Items = productResponse
        };
    }

    public async Task<Response.ProductDetailResponse?> GetProductById(int id)
    {
        var product = await _productRepository
            .GetByIdAsync(id, p => p.Category);

        if (product == null)
        {
            throw new Exception("Product not found");
        }
        
        var productResponse = _mapper.Map<Product, Response.ProductDetailResponse>(product);
        return productResponse;
    }

    public async Task<Product> AddProduct(Product product)
    {
        _productRepository.Add(product);

        var result = await _unitOfWork.SaveChangesAsync();
        
        if (result == false)
        {
            throw new Exception("Failed to add product");
        }
        
        return product;
    }

    public async Task<bool> UpdateProduct(Product product)
    {
        var existingProduct = await _productRepository.GetByIdAsync(product.Id);
        
        if (existingProduct == null)
        {
            throw new Exception("Product not found");
        }
        
        existingProduct.ProductName = product.ProductName;
        existingProduct.UnitPrice = product.UnitPrice;
        existingProduct.UnitsInStock = product.UnitsInStock;
        existingProduct.CategoryId = product.CategoryId;
        
        _productRepository.Update(existingProduct);
        
        var result = await _unitOfWork.SaveChangesAsync();

        return result;
    }

    public async Task<bool> DeleteProduct(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        
        if (product == null)
        {
            throw new Exception("Product not found");
        }
        
        _productRepository.Delete(product);
        
        var result = await _unitOfWork.SaveChangesAsync();
        
        return result;
    }
}

public static class ExpressionExtensions
{
    public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
    {
        var param = Expression.Parameter(typeof(T));
        var body = Expression.AndAlso(
            Expression.Invoke(left, param),
            Expression.Invoke(right, param)
        );
        
        return Expression.Lambda<Func<T, bool>>(body, param);
    }
}
