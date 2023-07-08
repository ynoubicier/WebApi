using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Core.Interfaces.Repositories
{
    public class DiagnosticRepository : GenericRepository<DiagnosticModel>, IDiagnosticRepository
    {
        public DiagnosticRepository(PlateformeDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<IEnumerable<DiagnosticModel>> All()
        {
            try
            {
                return await _context.Diagnostics.Where(x => x.IdDiagnostic < 100).ToListAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override async Task<DiagnosticModel?> GetById(int id)
        {
            try
            {
                return await _context.Diagnostics.AsNoTracking().FirstOrDefaultAsync(x => x.IdDiagnostic == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<DiagnosticModel?> GetByDiagnosticNb(int diagnosticNb)
        {
            try
            {
                return await _context.Diagnostics.FirstOrDefaultAsync(x => x.IdDiagnostic ==  diagnosticNb);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
