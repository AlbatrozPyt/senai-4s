using ProductsApiTest.Domains;

namespace ProductsApiTest.Interfaces
{
    public interface IProductsRepository
    {
        List<Products> Get();

        Products GetById(Guid id);

        void Post(Products products);

        void Put(Guid id, Products products);

        void Delete(Guid id);
    }
}
