using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Core.Interfaces.Repositories
{
    public class PartenaireRepository : GenericRepository<PartenaireModel>, IPartenaireRepository
    {
        public PartenaireRepository(PlateformeDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<IEnumerable<PartenaireModel>> All()
        {
            try
            {
                return await _context.Partenaires.Where(x => x.idPart < 100).ToListAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override async Task<PartenaireModel?> GetById(int id)
        {
            try
            {
                return await _context.Partenaires.AsNoTracking().FirstOrDefaultAsync(x => x.idPart == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<PartenaireModel?> GetByPartenaireNb(int partenaireNb)
        {
            try
            {
                return await _context.Partenaires.FirstOrDefaultAsync(x => x.idPart == partenaireNb);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
