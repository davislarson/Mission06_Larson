using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Mission06_Larson.Models;

public class Movie
{
    // Make sure certain values are required
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
    public bool? IsEdited { get; set; }
    public string? LentTo { get; set; }
    // This limits the value of the notes to 25 characters
    [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
    public string? Notes { get; set; }
}