﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViettinShop.Data.Infrastructure;
using ViettinShop.Model.Models;

namespace ViettinShop.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline>
    {

    }
    public class SupportOnlineRepository : RepositoryBase<SupportOnline>,ISupportOnlineRepository 
    {
        public SupportOnlineRepository (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
