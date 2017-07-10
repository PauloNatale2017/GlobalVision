using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.MapEntities.Entities
{
    public class CadastroLatLng : BaseEntity.EntityBase
    {       
        public String Endereco { get; set; }      
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }
}
