using System.Data.Entity; //tao buc minh r do
using System.Data.Entity.ModelConfiguration.Conventions;
using Asg1.Models;


namespace Asg1.DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext")
        {
        }
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}