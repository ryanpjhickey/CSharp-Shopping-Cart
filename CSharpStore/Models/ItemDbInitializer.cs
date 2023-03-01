using CSharpStore.Models;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using static CSharpStore.Models.ProductContext;

namespace CSharpStore.Models
{
    public class ItemDbInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Skincare"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Beauty"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Accessories"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Merchandise"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Miscellaneous"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Aloe Facemask",
                    Description = "This facemask will leave your face feeling refreshed!" +
                                  "Relax and clean those pores!",
                    ImagePath="",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Aloe Footmask",
                    Description = "This footmask will leave your feet feeling brand new!",
                    ImagePath="carearly.png",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Radical Red Lip Gloss",
                    Description = "Give your lips that red glow, perfect for every day use or for date night!",
                    ImagePath="lipGloss.png",
                    UnitPrice = 20.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Panda Bag Charm",
                    Description = "Add this cute little Panda bag charm to complete your panda set!",
                    ImagePath="pandaCharm.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Beauty2You Hat",
                    Description = "Rep our brand with this awesome baseball cap!",
                    ImagePath="baseHat.png",
                    UnitPrice = 40.00,
                    CategoryID = 4
                },
               new Product
                {
                    ProductID = 6,
                    ProductName = "Beauty2You Shirt",
                    Description = "Rep our brand with this awesome shirt!",
                    ImagePath="b2uShirt.png",
                    UnitPrice = 30.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Pen & Notebook",
                    Description = "Get a b2u themed pen and notebook to write down your skincare goals!",
                    ImagePath="penNote.png",
                    UnitPrice = 16.95,
                    CategoryID = 5
                }
            };

            return products;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override void InitializeDatabase(ProductContext context)
        {
            base.InitializeDatabase(context);
        }
    }
}