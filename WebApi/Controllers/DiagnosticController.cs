using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DiagnosticController : BaseApiController
    {
        private readonly PlateformeDbContext _context;

        public DiagnosticController(PlateformeDbContext context)
        {
            _context = context;
        }

        //[HttpGet("GetDiagnostic")]
        //[Route("GetDiagnostic")]
        [HttpGet]
        public async Task<IActionResult> GetDiagnostic()
        {
            try
            {
                var Diagnostics = await _context.Diagnostics.ToListAsync();
                return Ok(Diagnostics);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpGet("GetDiagnosticById")]
        //[Route("GetDiagnosticById")]
        [HttpGet]
        public async Task<IActionResult> GetDiagnosticById(int id)
        {
            try
            {
                var Diagnostic = await _context.Diagnostics.FirstOrDefaultAsync(x => x.IdDiagnostic == id);

                if(Diagnostic == null)
                {
                    return NotFound();
                }
                return Ok(Diagnostic);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPost("AddDiagnostic")]
        //[Route("AddDiagnostic")]
        [HttpPost]
        public async Task<IActionResult> AddDiagnostic(DiagnosticModel diagnostic)
        {
            try
            {
                _context.Diagnostics.Add(diagnostic);

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPatch("UpdateDiagnostic")]
        //[Route("UpdateDiagnostic")]
        [HttpPatch]
        public async Task<IActionResult> UpdateDiagnostic(DiagnosticModel diagnostic)
        {
            try
            {
                var existDiagnostic = await _context.Diagnostics.FirstOrDefaultAsync(x => x.IdDiagnostic == diagnostic.IdDiagnostic);

                if(existDiagnostic == null)
                {
                    return NotFound();
                }

                existDiagnostic.IdPA = diagnostic.IdPA;
                existDiagnostic.AssistantDiagnostic = diagnostic.AssistantDiagnostic;
                existDiagnostic.AssistantDistDiagnostic = diagnostic.AssistantDistDiagnostic;
                existDiagnostic.TransportMethodPA = diagnostic.TransportMethodPA;
                existDiagnostic.HobbiesDiagnostic = diagnostic.HobbiesDiagnostic;
                existDiagnostic.AmenitiesDiagnostic = diagnostic.AmenitiesDiagnostic;
                existDiagnostic.PracticeSportDiagnostic = diagnostic.PracticeSportDiagnostic;
                existDiagnostic.NameSportDiagnostic = diagnostic.NameSportDiagnostic;
                existDiagnostic.DispositifDiagnostic = diagnostic.DispositifDiagnostic;
                existDiagnostic.VisualProblemDiagnostic = diagnostic.VisualProblemDiagnostic;
                existDiagnostic.HealthMonitoringDiagnostic = diagnostic.HealthMonitoringDiagnostic;
                existDiagnostic.HearingProblemDiagnostic = diagnostic.HearingProblemDiagnostic;
                existDiagnostic.MemoryProblemDiagnostic = diagnostic.MemoryProblemDiagnostic;
                existDiagnostic.NecessaryAccompanimentDiagnostic = diagnostic.NecessaryAccompanimentDiagnostic;
                existDiagnostic.AssuranceContractDiagnostic = diagnostic.AssuranceContractDiagnostic;
                existDiagnostic.MarcheAccesDiagnostic = diagnostic.MarcheAccesDiagnostic;
                existDiagnostic.CommunePartiDiagnostic = diagnostic.CommunePartiDiagnostic;
                existDiagnostic.BuildingPeriodDiagnostic = diagnostic.BuildingPeriodDiagnostic;
                existDiagnostic.ConditionerAirDiagnostic = diagnostic.ConditionerAirDiagnostic;
                existDiagnostic.DetectorDiagnostic = diagnostic.DetectorDiagnostic;
                existDiagnostic.HotHomeDiagnostic = diagnostic.HotHomeDiagnostic;

                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpDelete("DeleteDiagnostic")]
        //[Route("DeleteDiagnostic")]
        [HttpDelete]
        public async Task<IActionResult> DeleteDiagnostic(int id)
        {
            try
            {
                var Diagnostic = await _context.Diagnostics.FirstOrDefaultAsync(x => x.IdDiagnostic == id);

                if(Diagnostic == null)
                {
                    return NotFound();
                }

                _context.Diagnostics.Remove(Diagnostic);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
