using API.Entities;

namespace API.Data{

public static class Intial{
    //creating a void method to check if there any values that matches to the values we wish to enter
    public static void Intialize(StoreContext context)
    {
        if(context.products.Any()) return;
        //creating a new list of products
        var products = new List<Product>
        {
            new Product{
                ProductName="MacBook",
                ProductType="Computer",
                ProductDescription= "this is computer that was published by apple",
                PorductPrice= 2000,
                AmountInStock= 100,
                PictureUrl= "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-mbp13-space-m1-2020_GEO_CA?wid=2000&hei=2000&fmt=jpeg&qlt=90&.v=1628621749000"

            },
            new Product {
                ProductName = "iPhone 13",
                ProductType = "Smartphone",
                ProductDescription = "The latest smartphone from Apple, featuring cutting-edge technology and a sleek design.",
                PorductPrice = 999,
                AmountInStock = 50,
                PictureUrl = "https://www.apple.com/newsroom/images/product/iphone/geo/Apple_iphone-13_product-image_GEO_08102021_big.jpg.large.jpg"
            },

            new Product {
                ProductName = "Apple Watch Series 7",
                ProductType = "Smartwatch",
                ProductDescription = "The newest iteration of Apple's smartwatch, offering advanced health monitoring and stylish customization options.",
                PorductPrice = 399,
                AmountInStock = 75,
                PictureUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/Apple-Watch-S7-Alum-SGPS-Black-202109?wid=1400&hei=1400&fmt=jpeg&qlt=80&.v=1631917493000"
            },

            new Product {
                ProductName = "iPad Air (2024)",
                ProductType = "Tablet",
                ProductDescription = "The latest iPad Air model, featuring a stunning Liquid Retina display and powerful A16 Bionic chip.",
                PorductPrice = 599,
                AmountInStock = 30,
                PictureUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/ip"

            
        },
                    new Product {
                ProductName = "MacBook Air",
                ProductType = "Laptop",
                ProductDescription = "Thin and light laptop from Apple, ideal for everyday use with long battery life and a stunning Retina display.",
                PorductPrice = 999,
                AmountInStock = 50,
                PictureUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/macbook-air-space-gray-select-202011?wid=904&hei=840&fmt=jpeg&qlt=80&.v=1603406904000"
            },

            new Product {
                ProductName = "iMac 24-inch",
                ProductType = "Desktop Computer",
                ProductDescription = "Elegant all-in-one desktop with a vibrant 24-inch Retina display, powerful M1 chip, and various color options.",
                PorductPrice = 1299,
                AmountInStock = 30,
                PictureUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/imac-24-gallery-202104?wid=904&hei=840&fmt=jpeg&qlt=80&.v=1617424548000"
            },

            new Product {
                ProductName = "Apple TV 4K",
                ProductType = "Media Player",
                ProductDescription = "High-definition streaming device with 4K HDR support and immersive sound from Dolby Atmos.",
                PorductPrice = 179,
                AmountInStock = 80,
                PictureUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/apple-tv-4k-hero-select-202104?wid=904&hei=840&fmt=jpeg&qlt=80&.v=1618007265000"
            },

            new Product {
                ProductName = "iPad Mini (2024)",
                ProductType = "Tablet",
                ProductDescription = "Compact and portable iPad mini with a stunning Liquid Retina display and the powerful A16 Bionic chip.",
                PorductPrice = 499,
                AmountInStock = 40,
                PictureUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/ipad-mini-2021-hero-202103?wid=904&hei=840&fmt=jpeg&qlt=80&.v=1616711136000"
            },

            new Product {
                ProductName = "Apple Watch SE",
                ProductType = "Smartwatch",
                ProductDescription = "Affordable yet powerful smartwatch from Apple, featuring heart rate monitoring, fitness tracking, and more.",
                PorductPrice = 279,
                AmountInStock = 60,
                PictureUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/apple-watch-se-hero-202009?wid=904&hei=840&fmt=jpeg&qlt=80&.v=1599817293000"
            }


    };
    // adding the products into the DB.
    foreach(var product in products){
        context.products.Add(product);
    }
    //saving the changes we have made above.
    context.SaveChanges();
    //another way to insert them into the table is as an list as you may see below
    //both ways are similar each other.
    //context.products.AddRange(products);
}
}
}
