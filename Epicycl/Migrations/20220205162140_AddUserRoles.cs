using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epicycl.Migrations
{
    public partial class AddUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b5a6d71-ea2f-439c-933b-f0710131fdc2", "24651a4f-3274-4fef-8ae8-79a0f2756e97", "SatelliteOwner", "SATELLITEOWNER" },
                    { "6994b808-51c8-414f-9375-9bd959b212dc", "2d044572-2d20-4b90-a3fc-a42895644ebd", "ServiceProvider", "SERVICEPROVIDER" },
                    { "923abb17-9cbf-421b-8ba5-41da22d5e40f", "339632b3-20b4-45f4-831c-2aa4596788cc", "Customer", "CUSTOMER" },
                    { "f2d72eb9-f3a8-4b1b-9f9f-da150247e528", "41482627-9a8d-4a2d-8a12-26df27b286ff", "AdminUser", "ADMINUSER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5a6d71-ea2f-439c-933b-f0710131fdc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6994b808-51c8-414f-9375-9bd959b212dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "923abb17-9cbf-421b-8ba5-41da22d5e40f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2d72eb9-f3a8-4b1b-9f9f-da150247e528");
        }
    }
}
