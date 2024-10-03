using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Services.Enums;

namespace Services.BusinessObject;

public class GetRequest
{
    public string? Search { get; set; }
    
    [JsonPropertyName("search-by")]
    [BindProperty(Name = "search-by")]
    public SearchBy SearchBy { get; set; } = SearchBy.Name;
    
    [JsonPropertyName("sort-by")]
    [BindProperty(Name = "sort-by")]
    public SortBy SortBy { get; set; } = SortBy.ProductName;
    
    [JsonPropertyName("sort-order")]
    [BindProperty(Name = "sort-order")]
    public SortOrder SortOrder { get; set; } = SortOrder.Asc;
    
    public string? Filter { get; set; }
    
    [JsonPropertyName("filter-operator")]
    [BindProperty(Name = "filter-operator")]
    public string? FilterOperator { get; set; }
    
    [JsonPropertyName("filter-by")]
    [BindProperty(Name = "filter-by")]
    public FilterBy FilterBy { get; set; } = FilterBy.UnitPrice;
    public int Page { get; set; } = 1;
    
    [JsonPropertyName("page-size")]
    [BindProperty(Name = "page-size")]
    public int PageSize { get; set; } = 100;
    
}