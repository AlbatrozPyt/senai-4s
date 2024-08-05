using Microsoft.AspNetCore.Mvc;
using ProductsApiTest.Contexts;
using ProductsApiTest.Controllers;
using Xunit;

namespace ProductsApiTest.Test
{
    public class ProductsTest
    {
        private readonly ProductsContext _context;

        public ProductsTest()
        {
            _context = new ProductsContext();
        }

        [Fact]
        public void GetProducts()
        {
            var controller = new ProductsController();

            var products = _context.Products.ToList();
            var routeGet = controller.Get();

            Assert.Equal(routeGet, products);
        }
    }
}