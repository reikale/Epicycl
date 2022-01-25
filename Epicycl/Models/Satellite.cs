using Microsoft.EntityFrameworkCore;

namespace Epicycl.Models
{
    public class Satellite
    {
        public enum Type
        {
            City,
            Montain,
            Electric,
            Hybrid
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
