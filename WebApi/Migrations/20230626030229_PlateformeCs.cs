using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class PlateformeCs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AideSoignantes",
                columns: table => new
                {
                    IdAS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastNameAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDateAs = table.Column<int>(type: "int", nullable: true),
                    BirthPlaceAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipcodeAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkplaceAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomaTitleAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialStatusAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatusAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordAS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AideSoignantes", x => x.IdAS);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostics",
                columns: table => new
                {
                    IdDiagnostic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPA = table.Column<int>(type: "int", nullable: false),
                    AssistantDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    AssistantDistDiagnostic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportMethodPA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbiesDiagnostic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmenitiesDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    PracticeSportDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    NameSportDiagnostic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FellTimeDiagnostic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispositifDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    VisualProblemDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    HealthMonitoringDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    HearingProblemDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    MemoryProblemDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    NecessaryAccompanimentDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    AssuranceContractDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    MarcheAccesDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    CommunePartiDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    BuildingPeriodDiagnostic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConditionerAirDiagnostic = table.Column<bool>(type: "bit", nullable: false),
                    DetectorDiagnostic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotHomeDiagnostic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostics", x => x.IdDiagnostic);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partenaires",
                columns: table => new
                {
                    idPart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypePart = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partenaires", x => x.idPart);
                });

            migrationBuilder.CreateTable(
                name: "PersonneAges",
                columns: table => new
                {
                    IdPA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNamePA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastNamePA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthdatePA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthplacePA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityPA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryPA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatusAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HousingTypePA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyTypePA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonneAges", x => x.IdPA);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastNameUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDateUser = table.Column<int>(type: "int", nullable: true),
                    BirthPlaceUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipcodeUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialStatusUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatusUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAdmin = table.Column<int>(type: "int", nullable: true),
                    UsernameAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.IdUser);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AideSoignantes");

            migrationBuilder.DropTable(
                name: "Diagnostics");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Partenaires");

            migrationBuilder.DropTable(
                name: "PersonneAges");

            migrationBuilder.DropTable(
                name: "Utilisateurs");
        }
    }
}
