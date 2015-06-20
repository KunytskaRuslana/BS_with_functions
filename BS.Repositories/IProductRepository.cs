﻿using BS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Repositories
{
    public interface IProductRepository
    {
        List<Product> SelectAll();

        Product Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
