﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViettinShop.Data.Infrastructure;
using ViettinShop.Model.Models;

namespace ViettinShop.Data.Repositories
{
    public interface IProductRepository
    {
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
