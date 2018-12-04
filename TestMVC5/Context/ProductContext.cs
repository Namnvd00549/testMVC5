using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestMVC5.Models;

namespace TestMVC5.Context
{
    public class ProductContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}