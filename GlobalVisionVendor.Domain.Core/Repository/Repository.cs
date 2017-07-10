using GlobalVisionVendor.Domain.Core.IRepositorio;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.Core.Repository
{
    public abstract class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {

        private readonly GlobalVisionVendor.DataAccessLayer.dbContext.dbContext _ctx;
        
        public Repository(GlobalVisionVendor.DataAccessLayer.dbContext.dbContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return _ctx.Set<TEntity>().Find(key);
        }

        public void Update(TEntity obj)
        {
            _ctx.Set<TEntity>().Attach(obj);
            _ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
           
        }

        public void SaveAll()
        {
            _ctx.SaveChanges();
        }

        public void Add(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
            _ctx.SaveChanges();
        }

        public void Exclude(Func<TEntity, bool> predicate)
        {
            _ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => _ctx.Set<TEntity>().Remove(del));
        }
       

        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
