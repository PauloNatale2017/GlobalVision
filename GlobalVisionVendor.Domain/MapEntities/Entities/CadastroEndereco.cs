using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.MapEntities.Entities
{
    public class CadastroEndereco : BaseEntity.EntityBase
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
    }
}
