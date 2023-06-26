using Microsoft.EntityFrameworkCore;

namespace WebApi.Models.PlateformeModels
{
    public class PlateformeDbContext : DbContext
    {
        public PlateformeDbContext(DbContextOptions options) : base(options) { }
        public DbSet<UtilisateurModel> Utilisateurs { get; set; }
        public DbSet<LoginModel> Login { get; set; }
        public DbSet<AideSoignanteModel> AideSoignantes { get; set; }
        public DbSet<AdministrateurModel> Administrateurs { get; set; }
        public DbSet<PersonneAgeModel> PersonneAges { get; set; }
        public DbSet<PartenaireModel> Partenaires { get; set; }
        public DbSet<DiagnosticModel> Diagnostics { get; set; }
    }
}
