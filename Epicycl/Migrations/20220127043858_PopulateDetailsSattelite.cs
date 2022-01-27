using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epicycl.Migrations
{
    public partial class PopulateDetailsSattelite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Advanced Composition Explorer (ACE)', 'Astronomical satellites', '25-08-1997', 'NASA', 'Advanced Composition Explorer (ACE or Explorer 71) is a NASA Explorer program satellite and space exploration mission to study matter comprising energetic particles from the solar wind, the interplanetary medium, and other sources.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Aeolus', 'Earth observation satellites', '22-08-2018', 'ESA', 'Aeolus is the first satellite mission to acquire profiles of Earth\'s wind on a global scale. These observations are being used to improve weather forecasts and climate models. The Aeolus satellite carries just one large instrument – a Doppler wind lidar that will measure the winds sweeping around our planet.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Advanced Land Observing Satellite - 2 (ALOS - 2)', 'Earth observation satellites', '24-05-2014', 'JAXA', 'The Advanced Land Observing Satellite-2 (ALOS-2) is follow-on mission from the \'DAICHI\', which contributed to cartography, regional observation, disaster monitoring, and resource surveys. ALOS-2 will succeed this mission with enhanced capabilities.\nSpecifically, JAXA is conducting research and development activities to improve wide and high - resolution observation technologies developed for DAICHI in order to further fulfill social needs.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Algeria Satellite - 1B (AlSat-1B)', 'Earth observation satellites', '26-09-2016', 'ASAL', 'Alsat-1B is an Algerian satellite operated by the Agence Spatiale Algerienne for agricultural and disaster monitoring. The contract for the mission was signed in July 2014. The satellite is based on the SSTL-100 bus. The satellite weighs 103 kilograms (227 lb) and carries an earth imaging payload with 12-metre (39 ft) panchromatic imager and 24-metre (79 ft) multispectral cameras.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Algeria Satellite - 2B (AlSat-2B)', 'Earth observation satellites', '26-09-2016', 'ASAL', 'AlSat-2 is an optical Earth observation project of CNTS (Algerian National Space Technology Centre).')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Amazônia-1', 'Earth observation satellites', '28-02-2021', 'INPE, AEB', 'The Amazônia-1 or SSR-1, is the first Earth observation satellite developed by Brazil, helped by Argentina\'s INVAP, who provided the main computer, attitude controls and sensors, and the training of Brazilian engineers, and launched at 04:54:00 UTC on 28 February 2021.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Earth Observation System - Aqua', 'Earth observation satellites', '04-05-2002', 'NASA', 'Aqua, Latin for water, is a NASA Earth Science satellite mission named for the large amount of information that the mission is collecting about the Earth\'s water cycle, including evaporation from the oceans, water vapor in the atmosphere, clouds, precipitation, soil moisture, sea ice, land ice, and snow cover on the land and ice. Additional variables also being measured by Aqua include radiative energy fluxes, aerosols, vegetation cover on the land, phytoplankton and dissolved organic matter in the oceans, and air, land, and water temperatures.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Arctica-M N1', 'Earth observation satellites', '28-02-2021', 'RosHydroMet , Roscosmos', 'Arktika-M is a series of planned Russian remote-sensing and emergency communications satellites operating in an highly elliptical 12-hour orbit. The constellation of two Aktika-M satellites is designed to monitor high-latitude areas of the Earth. The spacecraft will be based on Lavochkin\'s Elektro-L meteorological satellite.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Acceleration, Reconnection, Turbulence, and Electrodynamics of the Moon's Interaction with the Sun - P1 (ARTEMIS-P1)', 'Astronomical satellites', '15-07-2011', 'NASA', 'NASA's ARTEMIS mission (Acceleration, Reconnection, Turbulence and Electrodynamics of the Moon\'s Interaction with the Sun) is made up of two probes: P1 and P2. They were originally part of the successful THEMIS mission that orbited Earth and studied the aurora. NASA redirected the two probes to the Moon.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('Acceleration, Reconnection, Turbulence, and Electrodynamics of the Moon's Interaction with the Sun - P2 (ARTEMIS-P2)', 'Astronomical satellites', '15-07-2011', 'NASA', 'NASA's ARTEMIS mission (Acceleration, Reconnection, Turbulence and Electrodynamics of the Moon\'s Interaction with the Sun) is made up of two probes: P1 and P2. They were originally part of the successful THEMIS mission that orbited Earth and studied the aurora. NASA redirected the two probes to the Moon.')");
            migrationBuilder.Sql("INSERT INTO Satellites (Name, Type, LaunchDate, Operator, Description) VALUES ('[NAME]', '[TYPE]', '[LDATE]', '[OPERATOR]', '[DESCRIPTION]')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
