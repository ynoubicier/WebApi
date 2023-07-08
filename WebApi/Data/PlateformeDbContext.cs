using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class PlateformeDbContext : DbContext
    {
        public DbSet<UtilisateurModel> Utilisateurs { get; set; }
        public DbSet<LoginModel> Login { get; set; }
        public DbSet<AideSoignanteModel> AideSoignantes { get; set; }
        public DbSet<AdministrateurModel> Administrateurs { get; set; }
        public DbSet<PersonneAgeModel> PersonneAges { get; set; }
        public DbSet<PartenaireModel> Partenaires { get; set; }
        public DbSet<DiagnosticModel> Diagnostics { get; set; }
        public PlateformeDbContext(DbContextOptions options) : base(options) { }
    }
}
