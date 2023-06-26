namespace WebApi.Controllers
{
    public class AideSoignanteController : BaseApiController
    {
        public AideSoignanteController()
        {

        }

        [HttpGet("GetAS")]
        public async Task<IActionResult> GetAS()
        {
            try
            {
                return Ok("Aide");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("GetASById")]
        public async Task<IActionResult> GetASById(int IdAS)
        {
            try
            {
                return Ok("Aide");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("AddAS")]
        public async Task<IActionResult> AddAS()
        {
            try
            {
                return Ok("Aide");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("EditAS")]
        public async Task<IActionResult> EditAS()
        {
            try
            {
                return Ok("Aide");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("DeleteAS")]
        public async Task<IActionResult> DeleteAS()
        {
            try
            {
                return Ok("Aide");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
