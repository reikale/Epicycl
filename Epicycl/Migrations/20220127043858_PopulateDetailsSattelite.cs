using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epicycl.Migrations
{
    public partial class PopulateDetailsSattelite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, SpaceAgency, Terminated, Description) VALUES ('Compton Gamma Ray Observatory (CGRO)', 'Astronomical satellites', '05-04-1991', 'NASA', '04-06-2000', 'The Compton Gamma Ray Observatory (CGRO) was a space observatory detecting photons with energies from 20 keV to 30 GeV, in Earth orbit from 1991 to 2000. The observatory featured four main telescopes in one spacecraft, covering X-rays and gamma rays, including various specialized sub-instruments and detectors.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, SpaceAgency, Description) VALUES ('SES-1', 'Communication satellites', '24-04-2010', 'SES Americom', 'SES-1 is a geostationary communications satellite which is operated by SES World Skies, then by SES S.A..')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, SpaceAgency, Description) VALUES ('Sputnik 1', 'Earth observation satellite', '04-10-1957', 'USSR', '26-10-1957', 'Sputnik 1 was the first artificial Earth satellite. It was launched into an elliptical low Earth orbit by the Soviet Union on 4 October 1957 as part of the Soviet space program. It orbited for three weeks before its batteries ran out. The satellite then silently continued to orbit the planet for two months before it fell back into the atmosphere on 4 January 1958.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, SpaceAgency, Description) VALUES ('Explorer 1', 'Earth observation satellite', '01-02-1958', 'U.S.', '23-05-1958', 'Explorer 1 was the first satellite launched by the United States and was part of the U.S. participation in the International Geophysical Year. The mission followed the first two satellites the previous year; the Soviet Union\'s Sputnik 1 and Sputnik 2, beginning the Cold War Space Race between the two nations.')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
