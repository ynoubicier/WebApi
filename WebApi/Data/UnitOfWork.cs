using WebApi.Core.Interfaces;
using WebApi.Core.Interfaces.Repositories;

namespace WebApi.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PlateformeDbContext _context;
        private readonly ILogger _logger;

        public IAdministrateurRepository Administrateur { get; private set; }
        public IAideSoignanteRepository AideSoignante { get; private set; }
        public IDiagnosticRepository Diagnostic { get; private set; }
        public IPartenaireRepository Partenaire { get; private set; }
        public IPersonneAgeRepository PersonneAge { get; private set; }
        public IUtilisateurRepository Utilisateur { get; private set; }

        public UnitOfWork(
            PlateformeDbContext context,
            ILoggerFactory loggerFactory)
        {
            _context = context;
            var _logger = loggerFactory.CreateLogger("logs");

            Administrateur = new AdministrateurRepository(_context, _logger);
            AideSoignante = new AideSoignanteRepository(_context, _logger);
            Diagnostic = new DiagnosticRepository(_context, _logger);
            Partenaire = new PartenaireRepository(_context, _logger);
            PersonneAge = new PersonneAgeRepository(_context, _logger);
            Utilisateur = new UtilisateurRepository(_context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
