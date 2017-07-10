using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.Core.Repository
{
    public class CadastroLatLngRepository : Repository<GlobalVisionVendor.Domain.MapEntities.Entities.CadastroLatLng>
    {
        public CadastroLatLngRepository() : base(new DataAccessLayer.dbContext.dbContext())
        {

        }
    }
}
