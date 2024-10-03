using System.ComponentModel.DataAnnotations;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Repository.entities;
using Services.abstraction;
using Services.BusinessObject;
using Services.Enums;

namespace Lab3.Api.Controllers;

[ApiController]
[ApiVersion("2024-09-16")]
[Route("api/v{version:apiVersion}/products")]
public class ProductController : ControllerBase
{

    private readonly IProductServices _productServices;

    public ProductController(IProductServices productServices)
    {
        _productServices = productServices;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetRequest request)
    {
        var items = await _productServices
            .GetAllProducts(request.Search, 
                request.SearchBy,
                request.Filter,
                request.FilterOperator,
                request.FilterBy,
                request.Page, 
                request.PageSize, 
                request.SortBy,
                request.SortOrder);

        return Ok(items);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var item = await _productServices.GetProductById(id);
        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Request.ProductRequest request)
    {
        var product = new Product()
        {
            ProductName = request.ProductName,
            CategoryId = request.CategoryId,
            UnitsInStock = request.UnitsInStock,
            UnitPrice = request.UnitPrice
        };
        var item = await _productServices.AddProduct(product);
        return CreatedAtAction(nameof(Get), new {id = item.Id}, item);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Put([Required] int id, [FromBody] Request.ProductRequest request)
    {
        var product = new Product()
        {
            Id = id,
            ProductName = request.ProductName,
            CategoryId = request.CategoryId,
            UnitsInStock = request.UnitsInStock,
            UnitPrice = request.UnitPrice
        };
        
        var result = await _productServices.UpdateProduct(product);
        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([Required] int id)
    {
        var result = await _productServices.DeleteProduct(id);
        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}