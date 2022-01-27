using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epicycl.Migrations
{
    public partial class AddSatelliteImageLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Satellites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5002.jpg' WHERE Id = 5002");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5003.jpg' WHERE Id = 5003");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5004.jpg' WHERE Id = 5004");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5005.jpeg' WHERE Id = 5005");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5006.jpg' WHERE Id = 5006");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5007.jpg' WHERE Id = 5007");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5008.jpg' WHERE Id = 5008");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5009.jpg' WHERE Id = 5009");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5010.jpeg' WHERE Id = 5010");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/5011.jpg' WHERE Id = 5011");
            migrationBuilder.Sql("UPDATE Satellites SET ImageLink = '../wwwroot/img/CGRO.jpg' WHERE Id = 1");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Satellites");
        }
    }
}
