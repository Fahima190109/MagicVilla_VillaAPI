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
        public IEnumerable<VillaDTO> GetVillas()
        {
            //return new List<VillaDTO>()
            //{
            //    new VillaDTO{Id=1,Name = "Mehek"},
            //    new VillaDTO{Id=2,Name = "Fahima"}
            //};
            return VillaStore.villaList;
        }
      [HttpGet("id")]
        //[tpGet("{id : int}")]
        public VillaDTO Getvilla(int id)
        {
                return VillaStore.villaList.FirstOrDefault(u => u.Id == id);

        }
    }
}