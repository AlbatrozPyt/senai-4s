using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductsApiTest.Contexts;
using ProductsApiTest.Controllers;
using ProductsApiTest.Domains;
using ProductsApiTest.Interfaces;
using ProductsApiTest.Repositories;
using Xunit;

namespace ProductsApiTest.Test
{
    public class ProductsTest
    {
        /// <summary>
        /// Teste da funcionalidade, buscar todos os produtos
        /// </summary>
        [Fact]
        public void GetProducts()
        {
            // Arrange

            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid(), Nome = "Cachorro", Price = 20},
                new Products {IdProduct = Guid.NewGuid(), Nome = "Alho", Price = 2},
                new Products {IdProduct = Guid.NewGuid(), Nome = "Ossos de dinossauro", Price = 200},
            };

            var mockRepository = new Mock<IProductsRepository>();

            // Configura o metodo "Get" para que quando for acionado, retorne a lista mockada
            mockRepository.Setup(x => x.Get()).Returns(products);

            // Act

            // Executando o metodo "Get" e atribue a resposta em result
            var result = mockRepository.Object.Get();

            //Assert
            Assert.Equal(3, result.Count);

        }

        [Fact]
        public void PostProducts()
        {
            Products prod = new Products
            {
                IdProduct = Guid.NewGuid(),
                Nome = "Cachorro",
                Price = 7,
            };
            List<Products> products = new List<Products>();

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Post(prod))
                .Callback<Products>(x => products.Add(x));

            mockRepository.Object.Post(prod);

            Assert.Contains(prod, products);
        }

        [Fact]
        public void GetProductById()
        {
            Products product = new Products
            {
                IdProduct = Guid.NewGuid(),
                Nome = "Cachorro",
                Price = 7,
            };

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.GetById(product.IdProduct)).Returns(product);

            var result = mockRepository.Object.GetById(product.IdProduct);

            Assert.Equal(product, result);
        }

        [Theory]
        [InlineData("e5b178a0-cf6a-459a-b9b9-f7c7fb469bde")]
        public void DeleteById(Guid guid)
        {

            List<Products> products = new List<Products>
            {
                new Products {IdProduct = Guid.Parse("e5b178a0-cf6a-459a-b9b9-f7c7fb469bde"), Nome = "Ossos de dinossauro", Price = 200},
            };

            var busca = products.FirstOrDefault(x => x.IdProduct == guid)!;
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Delete(guid)).Callback(() => products.Remove(busca));

            mockRepository.Object.Delete(guid);

            Assert.Equal(0, products.Count);
        }

        [Theory]
        [InlineData("e5b178a0-cf6a-459a-b9b9-f7c7fb469bde")]
        public void PutProduct(Guid guid)
        {
            List<Products> products = new List<Products>
            {
                new Products
                {
                    IdProduct = Guid.Parse("e5b178a0-cf6a-459a-b9b9-f7c7fb469bde"),
                    Nome = "Cachorro",
                    Price = 21
                }
            };

            Products prod = new Products
            {
                Nome = "Gato",
                Price = 12
            };

            Products busca = products.FirstOrDefault(x => x.IdProduct == guid)!;

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Put(guid, prod))
                .Callback(() =>
                {
                    var item = products.FirstOrDefault(x => x.IdProduct == guid);

                    if (item != null)
                    {
                        item.Nome =  prod.Nome;
                        item.Price = prod.Price;
                    }
                });

            mockRepository.Object.Put(guid, prod);

            var novaBusca = products.FirstOrDefault(x => x.IdProduct == guid);

            Assert.Equal("Gato", novaBusca.Nome);
        }
    }
}