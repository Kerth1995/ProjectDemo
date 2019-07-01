using PrimerEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimerEjemplo.Context
{
    public class DataStore:DbContext
    {
        public DataStore()
            :base("demo01")
        {

        }
        public DbSet<Product> Products { set; get; }
    }
}