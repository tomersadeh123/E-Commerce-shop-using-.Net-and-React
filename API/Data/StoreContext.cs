using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data{

    // divers from the Dbcontext namespace
    // with this namespace we are able to add new product from our entity, delete new product and update a product.
    public class StoreContext : DbContext
    {
        // represnts a table in our DB.
        public DbSet<Product> products {get; set;}
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
    }
}