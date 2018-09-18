using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebApplication1.Models
{
    class NorthWindContext : DbContext
    {
        public NorthWindContext() : base("name=NorthWindConnection")
        {
        }
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }

    }
}
