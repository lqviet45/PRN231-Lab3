using System.ComponentModel.DataAnnotations;

namespace Repository.entities;

public class Category : Entity
{
    [Required]
    [StringLength(40)]
    public string? CategoryName { get; set; }
    
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}