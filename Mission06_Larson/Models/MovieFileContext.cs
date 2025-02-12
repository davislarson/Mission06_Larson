using Microsoft.EntityFrameworkCore;

namespace Mission06_Larson.Models;

public class MovieFileContext : DbContext
{
    public MovieFileContext(DbContextOptions<MovieFileContext> options) : base(options)
    {
    }
    
    // Allows for additions into a Movie table
    public DbSet<Movie> Movies { get; set; }
}