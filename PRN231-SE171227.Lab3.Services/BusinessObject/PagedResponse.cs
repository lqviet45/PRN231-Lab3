
using System.Text.Json.Serialization;

namespace Services.BusinessObject;

public class PagedResponse<T>
{
    
    [JsonPropertyName("page-size")]
    public int PageSize { get; set; }
    
    [JsonPropertyName("total-items")]
    public int TotalItems { get; set; }
    public int Page { get; set; }
    public IEnumerable<T> Items { get; set; } = new List<T>();
}

public class ProductResponse
{
    public int Id { get; set; }
    
    [JsonPropertyName("product-name")]
    public string? ProductName { get; set; }

    [JsonPropertyName("units-in-stock")]
    public int UnitsInStock { get; set; }
    
    [JsonPropertyName("unit-price")]
    public decimal UnitPrice { get; set; }
}