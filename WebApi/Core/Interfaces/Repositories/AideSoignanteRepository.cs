using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Core.Interfaces.Repositories
{
    public class AideSoignanteRepository : GenericRepository<AideSoignanteModel>, IAideSoignanteRepository
    {
        public AideSoignanteRepository(PlateformeDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<IEnumerable<AideSoignanteModel>> All()
        {
            try
            {
                return await _context.AideSoignantes.Where(x => x.IdAS < 100).ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override async Task<AideSoignanteModel?> GetById(int id)
        {
            try
            {
                return await _context.AideSoignantes.AsNoTracking().FirstOrDefaultAsync(x => x.IdAS == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<AideSoignanteModel?> GetByASNb(int asNb)
        {
            try
            {
                return await _context.AideSoignantes.FirstOrDefaultAsync(x => x.IdAS == asNb);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
