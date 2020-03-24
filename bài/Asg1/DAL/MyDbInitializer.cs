using System.Collections.Generic;
using System.Data.Entity;
using Asg1.Models;


namespace Asg1.DAL
{
    public class MyDbInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var category1 = new Category() { Name = "BVS" };
            var productBVS = new List<Product>()
            {
                new Product(){Name = "Kotex", Category = category1},
                new Product(){Name = "Diana", Category = category1},
                new Product(){Name = "Laurier", Category = category1},

            };

            category1.Products = productBVS;

            productBVS.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var category2 = new Category() { Name = "Laptop" };
            var productLap = new List<Product>()
            {
                new Product(){Name = "Asus", Category = category2 },
                new Product(){Name = "Macbook", Category = category2},
                new Product(){Name = "Dell", Category = category2},

            };

            category2.Products = productLap;

            productLap.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            //Add catogory to database
            //context.Categories.Add(category1);
            //context.Categories.Add(category2);
            //context.SaveChanges();
            //Add products to database
            /*foreach (var cate in context.Categories)
            {
                foreach (var product in cate.Products)
                {
                    context.Products.Add(product);
                }
            }*/
            base.Seed(context);
        }
    }
}