using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Core.Interfaces.Repositories
{
    public class UtilisateurRepository : GenericRepository<UtilisateurModel>, IUtilisateurRepository
    {
        public UtilisateurRepository(PlateformeDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<IEnumerable<UtilisateurModel>> All()
        {
            try
            {
                return await _context.Utilisateurs.Where(x => x.IdUser < 100).ToListAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override async Task<UtilisateurModel?> GetById(int id)
        {
            try
            {
                return await _context.Utilisateurs.AsNoTracking().FirstOrDefaultAsync(x => x.IdUser == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<UtilisateurModel?> GetByUtilisateurAgeNb(int utilisateurAgeNb)
        {
            try
            {
                return await _context.Utilisateurs.FirstOrDefaultAsync(x => x.IdUser == utilisateurAgeNb);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
