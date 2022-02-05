using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epicycl.Data
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "AdminUser",
                    NormalizedName = "ADMINUSER"
                },
                new IdentityRole
                {
                    Name = "ServiceProvider",
                    NormalizedName = "SERVICEPROVIDER"
                },
                new IdentityRole
                {
                    Name = "SatelliteOwner",
                    NormalizedName = "SATELLITEOWNER"
                },
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );
        }
    }
}
