using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*
        bool FilterByPrice(Product? p)
        {
            return (p?.Price ?? 0) >= 100;
        }
        */
        public ViewResult Index()
        {
            /*
            //return View(new string[] {"C#", "Language", "Features"});
            //Product?[] products = Product.GetProducts();
            //return View(new string[] { products[0].Name });
            
            Product?[] products = Product.GetProducts();

            /*
            Product? p = products[0];
            string val;
            if (p != null)
            {
                val = p.Name;
            }
            else
            {
                val = "No Value";
            }
            return View(new string[] { val });
            */

            /*
            string? val = products[1]?.Name;
            if (val != null)
            {
                return View(new string[] {val});
            }
            return View(new string[] {"No Value"});
            
            //return View(new string[] { products[0]?.Name ?? "No Value" });
            //return View(new string[] { products[0]!.Name });
            return View(new string[]
            {
                $"Name: {products[0]?.Name}, Price: {products[0]?.Price}"
            });

            */

            /*
            Dictionary<string, Product> products = new Dictionary<string, Product>{
                {"Kayak", new Product() {Name = "Kayak", Price = 1000M} },
                {"Lifejacket", new Product{Name = "Lifejacket", Price = 799M} }
            };
            */
            /*
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 1000M},
                ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 799M}
            };
            return View("Index", products.Keys);
            */
            ShoppingCart cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };
            /*
            Func<Product?, bool> nameFilter = delegate (Product? prod)
            {
                return prod?.Name[0] == 'L';
            };
            */

            decimal cartTotal = cart.FilterByPrice(100).TotalPrices();
            decimal nameFilterTotal = cart.Filter(p => p?.Name[0] == 'K').TotalPrices();

            return View("Index", new string[] {
                $"Total: {cartTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"});
        }
    }
}
