using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AideSoignanteController : BaseApiController
    {
        private readonly PlateformeDbContext _context;
        public AideSoignanteController(PlateformeDbContext context)
        {
            _context = context;
        }

        //[HttpGet("GetAS")]
        //[Route("GetAS")]
        [HttpGet]
        [Route("GetAS")]
        public async Task<IActionResult> GetAS()
        {
            try
            {
                var AideS = await _context.AideSoignantes.ToListAsync();
                return Ok(AideS);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //[HttpGet("GetASById")]
        //[Route("GetASById")]
        [HttpGet]
        [Route("GetASById")]
        public async Task<IActionResult> GetASById(int id)
        {
            try
            {
                var Aides = await _context.AideSoignantes.FirstOrDefaultAsync(x => x.IdAS == id);

                if(Aides == null)
                {
                    return NotFound();
                }
                return Ok(Aides);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPost("AddAS")]
        //[Route("AddAS")]
        [HttpPost]
        [Route("AddAS")]
        public async Task<IActionResult> AddAS(AideSoignanteModel aideSoignante)
        {
            try
            {
                _context.AideSoignantes.Add(aideSoignante);

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPatch("UpdateAS")]
        //[Route("UpdateAS")]
        [HttpPatch]
        [Route("UpdateAS")]
        public async Task<IActionResult> UpdateAS(AideSoignanteModel aideSoignante)
        {
            try
            {
                var existAs = await _context.AideSoignantes.FirstOrDefaultAsync(x => x.IdAS == aideSoignante.IdAS);

                if (existAs == null)
                {
                    return NotFound();
                }

                existAs.FirstNameAs = aideSoignante.FirstNameAs;
                existAs.LastNameAs = aideSoignante.LastNameAs;
                existAs.CityAS = aideSoignante.CityAS;
                existAs.CountryAS = aideSoignante.CountryAS;
                existAs.EmailAs = aideSoignante.EmailAs;
                existAs.PhoneAs = aideSoignante.PhoneAs;
                existAs.BirthDateAs = aideSoignante.BirthDateAs;
                existAs.BirthPlaceAs = aideSoignante.BirthPlaceAs;
                existAs.ZipcodeAS = aideSoignante.ZipcodeAS;
                existAs.WorkplaceAS = aideSoignante.WorkplaceAS;
                existAs.DiplomaTitleAS = aideSoignante.DiplomaTitleAS;
                existAs.SocialStatusAS = aideSoignante.SocialStatusAS;
                existAs.MaritalStatusAS = aideSoignante.MaritalStatusAS;

                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPatch("UpdatePasswordAS")]
        //[Route("UpdatePasswordAS")]
        [HttpPatch]
        [Route("UpdatePasswordAS")]
        public async Task<IActionResult> UpdatePasswordAS(AideSoignanteModel aideSoignante)
        {
            try
            {
                var existAs = await _context.AideSoignantes.FirstOrDefaultAsync(x => x.IdAS == aideSoignante.IdAS);

                if (existAs == null)
                {
                    return NotFound();
                }

                existAs.PasswordAS = aideSoignante.PasswordAS;

                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpDelete("DeleteAS")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAS(int id)
        {
            try
            {
                var Aides = await _context.AideSoignantes.FirstOrDefaultAsync(x => x.IdAS == id);

                if (Aides == null)
                {
                    return NotFound();
                }

                _context.AideSoignantes.Remove(Aides);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}