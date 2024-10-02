using System.Text.Json.Serialization;

namespace Services.BusinessObject;

public static class Response
{
    public class ProductDetailResponse
    {
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public int UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }
    }
}

public static class Request
{
    public class ProductRequest
    {
        [JsonIgnore] public int Id { get; set; }

        public string? ProductName { get; set; }

        public int CategoryId { get; set; }

        public int UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }
}