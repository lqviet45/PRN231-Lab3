﻿using System.ComponentModel.DataAnnotations;

namespace Repository.entities;

public class Product : Entity
{
    [Required]
    [StringLength(40)]
    public string? ProductName { get; set; }
    
    [Required]
    public int CategoryId { get; set; }
    
    [Required]
    public int UnitsInStock { get; set; }
    
    [Required]
    public decimal UnitPrice { get; set; }
    
    public virtual Category? Category { get; set; }
}