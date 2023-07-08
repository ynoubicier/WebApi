using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PartenaireController : BaseApiController
    {
        private readonly PlateformeDbContext _context;
        public PartenaireController(PlateformeDbContext context)
        {
            _context = context;
        }

        //[HttpGet("GetPartenaire")]
        //[Route("GetPartenaire")]
        [HttpGet]
        [Route("GetPartenaire")]
        public async Task<IActionResult> GetPartenaire()
        {
            try
            {
                var Partenaires = await _context.Partenaires.ToListAsync();
                return Ok(Partenaires);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpGet("GetPartenaireById")]
        //[Route("GetPartenaireById")]
        [HttpGet]
        [Route("GetPartenaireById")]
        public async Task<IActionResult> GetPartenaireById(int id)
        {
            try
            {
                var Partenaire = await _context.Partenaires.FirstOrDefaultAsync(x => x.idPart == id);

                if(Partenaire == null)
                {
                    return NotFound();
                }
                return Ok(Partenaire);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPost("AddPartenaire")]
        //[Route("AddPartenaire")]
        [HttpPost]
        [Route("AddPartenaire")]
        public async Task<IActionResult> AddPartenaire(PartenaireModel partenaire)
        {
            try
            {
                _context.Partenaires.Add(partenaire);

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPatch("UpdatePartenaire")]
        //[Route("UpdatePartenaire")]
        [HttpPatch]
        [Route("UpdatePartenaire")]
        public async Task<IActionResult> UpdatePartenaire(PartenaireModel partenaire)
        {
            try
            {
                var existPartenaire = await _context.Partenaires.FirstOrDefaultAsync(x => x.idPart == partenaire.idPart);

                if(existPartenaire == null)
                {
                    return NotFound();
                }

                existPartenaire.NamePart = partenaire.NamePart;
                existPartenaire.TypePart = partenaire.TypePart;

                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpDelete("DeletePartenaire")]
        //[Route("DeletePartenaire")]
        [HttpDelete]
        [Route("DeletePartenaire")]
        public async Task<IActionResult> DeletePartenaire(int id)
        {
            try
            {
                var Partenaire = await _context.Partenaires.FirstOrDefaultAsync(x => x.idPart == id);

                if(Partenaire == null)
                {
                    return NotFound();
                }

                _context.Partenaires.Remove(Partenaire);
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
