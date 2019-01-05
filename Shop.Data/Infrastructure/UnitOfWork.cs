using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private ShopDbContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }
        public ShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = _dbFactory.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
