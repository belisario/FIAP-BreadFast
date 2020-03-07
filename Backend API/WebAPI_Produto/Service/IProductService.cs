using System.Collections.Generic;
using WebAPI_Produto.Models;

namespace WebAPI_Produto.Service
{
    public interface IProductService
    {
        Product GetProduct(string name);
        List<Product> GetProduct();
        List<Product> GetProductByType(string type);
        void CreateProduct(Product product);
        Product UpdateProduct(string name, Product product);
        bool RemoveProduct(string name);
    }
}