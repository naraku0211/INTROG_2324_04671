using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SimpleApp.Controllers;
using SimpleApp.Models;
using Xunit;

namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        class FakeDataSource : IDataSource
        {
            public FakeDataSource(Product[] data) => Products = data;
            public IEnumerable<Product> Products { get; set; }
        }

        [Fact]
        public void IndexActionModelIsComplete()
        {
            //Arrange
            Product[] testData = new Product[]
            {
                new Product { Name = "Test1", Price = 100M },
                new Product { Name = "Test2", Price = 200M },
                new Product { Name = "Test3", Price = 300M }
            };

            IDataSource data = new FakeDataSource(testData);
            var controller = new HomeController();
            controller.dataSource = data;

            //Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;

            //Assert
            Assert.Equal(data.Products, model,
                Comparer.Get<Product>((p1, p2) => p1?.Name == p2?.Name
                && p1?.Price == p2?.Price));

        }

    }
}
