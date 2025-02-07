using Microsoft.EntityFrameworkCore;

namespace Mission06_Larson.Models;

public class MovieFileContext : DbContext
{
    public MovieFileContext(DbContextOptions<MovieFileContext> options) : base(options)
    {
        
    }
    
    public DbSet<Movie> Movies { get; set; }
}