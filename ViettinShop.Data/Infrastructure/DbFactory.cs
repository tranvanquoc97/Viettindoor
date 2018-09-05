using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViettinShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ViettinShopDbContext dbContext;

        public ViettinShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ViettinShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
