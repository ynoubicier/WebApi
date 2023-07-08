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
                    IdAS = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstNameAs = table.Column<string>(type: "TEXT", nullable: false),
                    LastNameAs = table.Column<string>(type: "TEXT", nullable: false),
                    CityAS = table.Column<string>(type: "TEXT", nullable: false),
                    CountryAS = table.Column<string>(type: "TEXT", nullable: false),
                    EmailAs = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneAs = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDateAs = table.Column<int>(type: "INTEGER", nullable: false),
                    BirthPlaceAs = table.Column<string>(type: "TEXT", nullable: false),
                    ZipcodeAS = table.Column<string>(type: "TEXT", nullable: false),
                    WorkplaceAS = table.Column<string>(type: "TEXT", nullable: false),
                    DiplomaTitleAS = table.Column<string>(type: "TEXT", nullable: false),
                    SocialStatusAS = table.Column<string>(type: "TEXT", nullable: false),
                    MaritalStatusAS = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordAS = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AideSoignantes", x => x.IdAS);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostics",
                columns: table => new
                {
                    IdDiagnostic = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPA = table.Column<int>(type: "INTEGER", nullable: false),
                    AssistantDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    AssistantDistDiagnostic = table.Column<string>(type: "TEXT", nullable: false),
                    TransportMethodPA = table.Column<string>(type: "TEXT", nullable: false),
                    HobbiesDiagnostic = table.Column<string>(type: "TEXT", nullable: false),
                    AmenitiesDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    PracticeSportDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    NameSportDiagnostic = table.Column<string>(type: "TEXT", nullable: false),
                    FellTimeDiagnostic = table.Column<string>(type: "TEXT", nullable: false),
                    DispositifDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    VisualProblemDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    HealthMonitoringDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    HearingProblemDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    MemoryProblemDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    NecessaryAccompanimentDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    AssuranceContractDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    MarcheAccesDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CommunePartiDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    BuildingPeriodDiagnostic = table.Column<string>(type: "TEXT", nullable: false),
                    ConditionerAirDiagnostic = table.Column<bool>(type: "INTEGER", nullable: false),
                    DetectorDiagnostic = table.Column<string>(type: "TEXT", nullable: false),
                    HotHomeDiagnostic = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostics", x => x.IdDiagnostic);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partenaires",
                columns: table => new
                {
                    idPart = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NamePart = table.Column<string>(type: "TEXT", nullable: false),
                    TypePart = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partenaires", x => x.idPart);
                });

            migrationBuilder.CreateTable(
                name: "PersonneAges",
                columns: table => new
                {
                    IdPA = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstNamePA = table.Column<string>(type: "TEXT", nullable: false),
                    LastNamePA = table.Column<string>(type: "TEXT", nullable: false),
                    BirthdatePA = table.Column<string>(type: "TEXT", nullable: false),
                    BirthplacePA = table.Column<string>(type: "TEXT", nullable: false),
                    CityPA = table.Column<string>(type: "TEXT", nullable: false),
                    CountryPA = table.Column<string>(type: "TEXT", nullable: false),
                    SocialStatus = table.Column<string>(type: "TEXT", nullable: false),
                    MaritalStatusAS = table.Column<string>(type: "TEXT", nullable: false),
                    HousingTypePA = table.Column<string>(type: "TEXT", nullable: false),
                    PropertyTypePA = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonneAges", x => x.IdPA);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstNameUser = table.Column<string>(type: "TEXT", nullable: false),
                    LastNameUser = table.Column<string>(type: "TEXT", nullable: false),
                    EmailUser = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneUser = table.Column<string>(type: "TEXT", nullable: false),
                    CitizenshipUser = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDateUser = table.Column<int>(type: "INTEGER", nullable: false),
                    BirthPlaceUser = table.Column<string>(type: "TEXT", nullable: false),
                    StreetUser = table.Column<string>(type: "TEXT", nullable: false),
                    CityUser = table.Column<string>(type: "TEXT", nullable: false),
                    StateUser = table.Column<string>(type: "TEXT", nullable: false),
                    ZipcodeUser = table.Column<string>(type: "TEXT", nullable: false),
                    SocialStatusUser = table.Column<string>(type: "TEXT", nullable: false),
                    MaritalStatusUser = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    IdAdmin = table.Column<int>(type: "INTEGER", nullable: true),
                    UsernameAdmin = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordAdmin = table.Column<string>(type: "TEXT", nullable: true)
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
