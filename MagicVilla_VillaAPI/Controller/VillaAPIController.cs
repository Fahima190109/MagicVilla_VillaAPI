using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controller
{
    //[Route("api/ Controller")]
    [Route("api/ VillaAPIController")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            //return new List<VillaDTO>()
            //{
            //    new VillaDTO{Id=1,Name = "Mehek"},
            //    new VillaDTO{Id=2,Name = "Fahima"}
            //};
            return Ok(VillaStore.villaList);
        }
      [HttpGet("id")]
        //[tpGet("{id : int}")]
        public ActionResult<VillaDTO> Getvilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);

        }
    }
}