using System.ComponentModel.DataAnnotations;

namespace Mission06_Larson.Models;

public class Category
{
    [Required]
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; }
}