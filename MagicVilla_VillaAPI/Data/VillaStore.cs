using MagicVilla_VillaAPI.Models.DTO;
using System.Reflection.Metadata.Ecma335;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
         public static  List<VillaDTO> villaList = new List<VillaDTO>
            
         {
                new VillaDTO{Id=1,Name = "Mehek"},
                new VillaDTO{Id=2,Name = "Fahima"}
            };
    }
}
