using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class BlazorMovieAppContext:DbContext
    {
        public BlazorMovieAppContext(DbContextOptions<BlazorMovieAppContext> options)
          : base(options)
        {
        }

        public DbSet<BlazorApp.Movie> Movie { get; set; } = default!;
    }
}
