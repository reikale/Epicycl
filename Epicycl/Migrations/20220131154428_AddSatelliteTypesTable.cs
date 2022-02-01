using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epicycl.Migrations
{
    public partial class AddSatelliteTypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SatelliteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatelliteTypes", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO SatelliteTypes (Name) VALUES ('Astronomical satellites')");
            migrationBuilder.Sql("INSERT INTO SatelliteTypes (Name) VALUES ('Earth observation satellites')");
            migrationBuilder.Sql("INSERT INTO SatelliteTypes (Name) VALUES ('Communication satellites')");
            migrationBuilder.Sql("INSERT INTO SatelliteTypes (Name) VALUES ('Navigational satellites')");
            migrationBuilder.Sql("INSERT INTO SatelliteTypes (Name) VALUES ('Space stations')");
            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "SatelliteTypes");
        }
    }
}
