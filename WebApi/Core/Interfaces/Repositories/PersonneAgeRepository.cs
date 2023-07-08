using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Core.Interfaces.Repositories
{
    public class PersonneAgeRepository : GenericRepository<PersonneAgeModel>, IPersonneAgeRepository
    {
        public PersonneAgeRepository(PlateformeDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<IEnumerable<PersonneAgeModel>> All()
        {
            try
            {
                return await _context.PersonneAges.Where(x => x.IdPA < 100).ToListAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override async Task<PersonneAgeModel?> GetById(int id)
        {
            try
            {
                return await _context.PersonneAges.AsNoTracking().FirstOrDefaultAsync(x => x.IdPA == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<PersonneAgeModel?> GetByPersonneAgeNb(int personneAgeNb)
        {
            try
            {
                return await _context.PersonneAges.FirstOrDefaultAsync(x => x.IdPA == personneAgeNb);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
