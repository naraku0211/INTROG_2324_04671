namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;

        public decimal? Price { get; set; }

        //Product?[]? arr1 = new Product{kayak, lifejacket, null};
        //Product[]? arr2 = null;

        public static Product?[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 1000M
            };

            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 799M
            };

            Product football = new Product();
            football.Name = "Football";
            football.Price = 249.95M;

            Product pingball = new Product();
            pingball.Name = "PingPong ball";
            pingball.Price = 50M;

            return new Product?[] { kayak, lifejacket, football, pingball };
        }
    }
}
