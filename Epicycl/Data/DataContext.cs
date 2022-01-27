using Epicycl.Models;
using Microsoft.EntityFrameworkCore;

namespace Epicycl.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Satellite> Satellites { get; set; }
    }
}
