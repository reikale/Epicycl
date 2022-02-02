using Epicycl.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Epicycl.Data
{
    public class DataContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Satellite> Satellites { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<SatelliteTypes> SatelliteTypes { get; set; }
        public DbSet<SubscribtionTypes> SubscribtionTypes { get; set; }
    }
}
