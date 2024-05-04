using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<StoreDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person.",
                        Category = "Watersports",
                        Price = 499.95m
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fasionable.",
                        Category = "Watersports",
                        Price = 249.95m
                    },
                    new Product
                    {
                        Name = "Soccer ball",
                        Description = "FIFA-Approved size and weight",
                        Category = "Soccer",
                        Price = 399.95m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch.",
                        Category = "Soccer",
                        Price = 999.95m
                    },
                    new Product
                    {
                        Name = "Staduim",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 99499.95m
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve your brain efficiency by 75%.",
                        Category = "Chess",
                        Price = 699.95m
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly giving your opponent a disadvantage.",
                        Category = "Chess",
                        Price = 399.95m
                    },
                    new Product
                    {
                        Name = "Chess Board",
                        Description = "A fun game to the family.",
                        Category = "Chess",
                        Price = 299.95m
                    },
                    new Product
                    {
                        Name = "Bling-bling King",
                        Description = "Gold-plated sturdy King",
                        Category = "Chess",
                        Price = 199.95m
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
