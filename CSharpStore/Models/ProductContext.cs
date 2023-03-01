using Microsoft.AspNetCore.Builder;
using System.Data;
using System.Collections.Generic;

namespace CSharpStore.Models
{
        public class ProductContext : DbContext
        {
            public ProductContext() : base("CSharpStore")
            {}
            public DbSet<Category> Categories { get; set; }
            public DbSet<Product> Products { get; set; }
        }

}
