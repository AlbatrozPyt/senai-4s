using Microsoft.EntityFrameworkCore;
using ProductsApiTest.Contexts;
using ProductsApiTest.Domains;
using ProductsApiTest.Interfaces;

namespace ProductsApiTest.Repositories
{
    public class ProductsRepositories : IProductsRepository
    {
        private readonly ProductsContext _context;

        public ProductsRepositories()
        {
            _context = new ProductsContext();
        }

        public void Delete(Guid id)
        {
            try
            {
                Products product = _context.Products.FirstOrDefault(x => x.IdProduct == id)!;
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Products> Get()
        {
           return _context.Products.ToList();
        }

        public Products GetById(Guid id)
        {
            return _context.Products.FirstOrDefault(x => x.IdProduct == id)!;
        }

        public void Post(Products products)
        {
            try
            {
                _context.Products.Add(products);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Put(Guid id, Products products)
        {
            try
            {
                Products product = _context.Products.FirstOrDefault(x => x.IdProduct == id)!;

                if (product != null) 
                {
                    product.Nome = products.Nome == null ? product.Nome : products.Nome;
                    product.Price = products.Price == 0 ? product.Price : products.Price;
                }

                _context.Products.Update(product!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
