using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controller{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController: ControllerBase
    {
        private readonly StoreContext context;
        public ProductsController(StoreContext context)
        {
            this.context = context;

            
        }

        // creating a methoid to get a list of all products from our DB.
        [HttpGet]
        public async Task<IEnumerable<Product>> Getproducts()
        {

             return await context.products.ToListAsync();
            

        }

        [HttpGet("{id}")]
        //method to retrive the product by their id's
        public  IEnumerable<Product> GetPeoductByID(int id)
        {
            var product = context.products.Where(x => x.Id == id);
            return product;
        }

        // method to add product
        [HttpPost]
        public void AddProduct(string name,string type, string description, float price, int stock, string picURL )
        {
            Product product = new Product
            {
                ProductName = name,
                ProductType = type,
                ProductDescription = description,
                PorductPrice = price,
                AmountInStock = stock,
                PictureUrl = picURL

            };
            context.products.Add(product);


        }
        
        
        

    }

}