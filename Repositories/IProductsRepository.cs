using System.Collections.Generic;
using ProductsSP.Models;

namespace ProductsSP.Repositories
{
    public interface IProductsRepository
    {
         List<Product> GetAllProducts();
         Product GetProduct(int id);
    }
}