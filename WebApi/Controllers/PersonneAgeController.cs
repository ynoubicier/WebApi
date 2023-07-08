using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PersonneAgeController : BaseApiController
    {
        private readonly PlateformeDbContext _context;

        public PersonneAgeController(PlateformeDbContext context)
        {
            _context = context;
        }

        //[HttpGet("GetPersonneAge")]
        //[Route("GetPersonneAge")]
        [HttpGet]
        public async Task<IActionResult> GetPersonneAge()
        {
            try
            {
                var PersonneAges = await _context.PersonneAges.ToListAsync();
                return Ok(PersonneAges);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpGet("GetPersonneAgeById")]
        //[Route("GetPersonneAgeById")]
        [HttpGet]
        public async Task<IActionResult> GetPersonneAgeId(int id)
        {
            try
            {
                var PersonneAge = await _context.PersonneAges.FirstOrDefaultAsync(x => x.IdPA == id);

                if(PersonneAge == null)
                {
                    return NotFound();
                }
                return Ok(PersonneAge);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPost("AddPartenaire")]
        //[Route("AddPartenaire")]
        [HttpPost]
        public async Task<IActionResult> AddPersonneAge(PersonneAgeModel personneAge)
        {
            try
            {
                _context.PersonneAges.Add(personneAge);

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPatch("UpdatePersonneAge")]
        //[Route("UpdatePersonneAge")]
        [HttpPatch]
        public async Task<IActionResult> UpdatePersonneAge(PersonneAgeModel personneAge)
        {
            try
            {
                var existPersonneAge = await _context.PersonneAges.FirstOrDefaultAsync(x => x.IdPA == personneAge.IdPA);

                if(existPersonneAge == null)
                {
                    return NotFound();
                }

                existPersonneAge.FirstNamePA = personneAge.FirstNamePA;
                existPersonneAge.LastNamePA = personneAge.LastNamePA;
                existPersonneAge.BirthdatePA = personneAge.BirthdatePA;
                existPersonneAge.BirthplacePA = personneAge.BirthplacePA;
                existPersonneAge.CityPA = personneAge.CityPA;
                existPersonneAge.CountryPA = personneAge.CountryPA;
                existPersonneAge.SocialStatus = personneAge.SocialStatus;
                existPersonneAge.MaritalStatusAS = personneAge.MaritalStatusAS;
                existPersonneAge.HousingTypePA = personneAge.HousingTypePA;
                existPersonneAge.PropertyTypePA = personneAge.PropertyTypePA;

                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpDelete("DeletePersonneAge")]
        //[Route("DeletePersonneAge")]
        [HttpDelete]
        public async Task<IActionResult> DeletePersonneAge(int id)
        {
            try
            {
                var PersonneAge = await _context.PersonneAges.FirstOrDefaultAsync(x => x.IdPA == id);

                if(PersonneAge == null)
                {
                    return NotFound();
                }

                _context.PersonneAges.Remove(PersonneAge);
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
