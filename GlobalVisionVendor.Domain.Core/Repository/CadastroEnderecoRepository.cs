using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.Core.Repository
{
    public class CadastroEnderecoRepository : Repository<GlobalVisionVendor.Domain.MapEntities.Entities.CadastroEndereco>
    {
        public CadastroEnderecoRepository() : base(new DataAccessLayer.dbContext.dbContext())
        {

        }
    }
}
