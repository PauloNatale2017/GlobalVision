using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GlobalVisionVendor.DataAccessLayer.dbContext
{
    public class dbContext : DbContext
    {

        public dbContext() : base("name=dbLocal") { }      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<GlobalVisionVendor.Domain.MapEntities.Entities.CadastroEndereco> _CadastroEndereco { get; set; }
        public DbSet<GlobalVisionVendor.Domain.MapEntities.Entities.CadastroLatLng> _CadastroLatLng { get; set; }

    }
}
