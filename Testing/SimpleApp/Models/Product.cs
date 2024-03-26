
namespace SimpleApp.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }

        /*
        public static Product[] GetProducts()
        {
            Product kayak = new Product 
            { 
                Name = "Kayak", 
                Price = 500M 
            };
            Product lifejacket = new Product 
            { 
                Name = "Lifejacket", 
                Price = 249.95M 
            };
            
            return new Product[] { kayak, lifejacket };
        }
        */
    }

    public class ProductDataSource : IDataSource
    {
        public IEnumerable<Product> Products =>
            new Product[]
            {
                new Product { Name = "Kayak", Price = 500M },
                new Product { Name = "Lifejacket", Price = 249.95M }
            };
    }
}
