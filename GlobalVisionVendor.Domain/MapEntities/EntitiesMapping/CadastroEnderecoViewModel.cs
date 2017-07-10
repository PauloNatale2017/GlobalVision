using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.MapEntities.EntitiesMapping
{
    [Table("EnderecoMap")]
    public class CadastroEnderecoViewModel
    {
        [Required]
        [Display(Name = "Nome")]
        public String Endereco { get; set; }

        [Required]
        [Display(Name = "Latitude")]
        public String Latitude { get; set; }

        [Required]
        [Display(Name = "Longitude")]
        public String Longitude { get; set; }
    }
}
