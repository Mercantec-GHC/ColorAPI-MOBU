using Microsoft.EntityFrameworkCore;
using RGB_API.Models;

namespace RGB_API.Data
{
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public AppDBContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Color> Colors { get; set; }
       // public DbSet<UserDTO> UserDTO { get; set; } = default!;
    }
}
