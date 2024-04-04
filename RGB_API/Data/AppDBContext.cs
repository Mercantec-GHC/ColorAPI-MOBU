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
            var a = configuration.GetConnectionString("DefaultConnection");
            var b = Environment.GetEnvironmentVariable("DefaultConnection");
            Console.WriteLine("==============");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a ?? b);
            optionsBuilder.UseNpgsql(a ?? b);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Color> Colors { get; set; }
       // public DbSet<UserDTO> UserDTO { get; set; } = default!;
    }
}
