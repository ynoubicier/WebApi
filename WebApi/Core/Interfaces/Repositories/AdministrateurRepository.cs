using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Core.Interfaces.Repositories
{
    public class AdministrateurRepository : GenericRepository<AdministrateurModel>, IAdministrateurRepository
    {
        public AdministrateurRepository(PlateformeDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<IEnumerable<AdministrateurModel>> All()
        {
            try
            {
                return await _context.Administrateurs.Where(x => x.IdAdmin < 100).ToListAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override async Task<AdministrateurModel?> GetById(int id)
        {
            try
            {
                return await _context.Administrateurs.AsNoTracking().FirstOrDefaultAsync(x => x.IdAdmin == id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<AdministrateurModel?> GetByAdminNb(int adminNb)
        {
            try
            {
                return await _context.Administrateurs.FirstOrDefaultAsync(x => x.IdAdmin == adminNb);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
