using Microsoft.EntityFrameworkCore;
using WebApi.Core.Interfaces;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AdministrateurController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdministrateurController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetAdmin")]
        public async Task<IActionResult> GetAdmin()
        {
            try
            {
                var Admin = await _unitOfWork.Administrateur.All();
                return Ok(Admin);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpGet("GetAdminById")]
        //[Route("GetAdminById")]
        [HttpGet]
        [Route("GetAdminById")]
        public async Task<IActionResult> GetAdminById(int id)
        {
            try
            {
                var admin = await _unitOfWork.Administrateur.GetById(id);

                if (admin == null)
                {
                    return NotFound();
                }
                return Ok(admin);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPost("AddAdmin")]
        //[Route("AddAdmin")]
        [HttpPost]
        [Route("AddAdmin")]
        public async Task<IActionResult> AddAdmin(AdministrateurModel administrateur)
        {
            try
            {
                await _unitOfWork.Administrateur.Add(administrateur);

                await _unitOfWork.CompleteAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPatch("UpdateAdmin")]
        //[Route("UpdateAdmin")]
        [HttpPatch]
        [Route("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin(AdministrateurModel administrateur)
        {
            try
            {
                var existAdmin = await _unitOfWork.Administrateur.GetById(administrateur.IdAdmin);

                if (existAdmin == null)
                {
                    return NotFound();
                }


                await _unitOfWork.Administrateur.Update(administrateur);
                await _unitOfWork.CompleteAsync();

                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpDelete("DeleteAdmin")]
        //[Route("DeleteAdmin")]
        [HttpDelete]
        [Route("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            try
            {
                var Admin = await _unitOfWork.Administrateur.GetById(id);

                if(Admin == null)
                {
                    return NotFound();
                }

                await _unitOfWork.Administrateur.Delete(Admin);
                await _unitOfWork.CompleteAsync();

                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
