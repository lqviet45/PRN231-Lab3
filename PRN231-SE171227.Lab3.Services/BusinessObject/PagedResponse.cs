
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
    
    public string? ProductName { get; set; }

    public int UnitsInStock { get; set; }
    
    public decimal UnitPrice { get; set; }
}