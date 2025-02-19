using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;


namespace Mission06_Larson.Models;

public class Movie
{
    // Make sure certain values are required
    [Key]
    [Required]
    public int MovieID { get; set; }
    [Required]
    public string Title { get; set; }
    [Required (ErrorMessage = "Enter a year after 1888.")]
    [Range(1888, 2025)]
    public int Year { get; set; }
    [Required]
    public bool CopiedToPlex { get; set; }
    [Required]
    public bool Edited { get; set; }
    public string? Director { get; set; }
    public string? Rating { get; set; }
    public string? LentTo { get; set; }
    // This limits the value of the notes to 25 characters
    [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
    public string? Notes { get; set; }
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}
