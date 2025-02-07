using System.ComponentModel.DataAnnotations;

namespace Mission06_Larson.Models;

public class Movie
{
    [Key]
    [Required]
    public int MovieID { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Category { get; set; }
    [Required]
    public int YearReleased { get; set; }
    [Required]
    public string Director { get; set; }
    [Required]
    public string Rating { get; set; }
    
    public bool IsEdited { get; set; }
    
    public string LentTo { get; set; }
    
    [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
    public string Notes { get; set; }
}