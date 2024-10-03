using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Services.BusinessObject;

public static class Response
{
    public class ProductDetailResponse
    {
        public int Id { get; set; }
        
        [JsonPropertyName("product-name")]
        public string? ProductName { get; set; }

        [JsonPropertyName("units-in-stock")]
        public int UnitsInStock { get; set; }

        [JsonPropertyName("unit-price")]
        public decimal UnitPrice { get; set; }
        
        [JsonPropertyName("category-id")]
        public int CategoryId { get; set; }

        [JsonPropertyName("category-name")]
        public string? CategoryName { get; set; }
    }
}

public static class Request
{
    public class ProductRequest
    {
        [JsonIgnore] public int Id { get; set; }

        [JsonPropertyName("product-name")]
        [Required]
        public string? ProductName { get; set; }

        [JsonPropertyName("category-id")]
        [Required]
        public int CategoryId { get; set; }

        [JsonPropertyName("units-in-stock")]
        [Required]
        public int UnitsInStock { get; set; }

        [JsonPropertyName("unit-price")]
        [Required]
        public decimal UnitPrice { get; set; }
    }
}