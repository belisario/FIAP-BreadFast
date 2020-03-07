using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_Produto.Models;

namespace WebAPI_Produto.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        
        public ProductRepository()
        {
            _products.Add(new Product(){Name = "Pão Francês", Description = "Preço referente a unidade.", Price = 1.0, Type = "Pães", URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcShRVEgQzdQsqck-uWatfNdtEXJdq-gM9qeXEBVeku_fcDP_sc1" });
            _products.Add(new Product(){Name = "Pão de Queijo", Description = "Preço referente a 100 gramas.", Price = 2.50, Type = "Pães", URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSBCvgI_8GyLxmY1skDNyVMWkEAZJ_nBDr_WQxBJhRk0xGn7CWR" });
            _products.Add(new Product(){Name = "Pão Sovado", Description = "Preço referente a unidade.", Price = 3.0, Type = "Pães", URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQifmfsqzMGvALjquwpBADy55BcnW77dV5wCFjrYbd7SF8hA1n8" });
            _products.Add(new Product(){Name = "Pão de Trança", Description = "Preço referente a unidade.", Price = 5.0, Type = "Pães", URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRSSl2eVyhkBvZE6uXvt5qZ55oQ07IKESxY6bqjZ64sfZf5eitY" });
            _products.Add(new Product(){Name = "Pão Caseiro", Description = "Preço referente a unidade.", Price = 1.0, Type = "Pães", URL = "https://blog-cdn.eduk.com.br/wp-content/uploads/sites/3/2017/12/13123802/p%C3%A3o-caseiro-2.jpg" });
            _products.Add(new Product(){Name = "Pão de Leite", Description = "Preço referente a unidade.", Price = 2.0, Type = "Pães", URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR8Eozs01eLEsBu3kCM_Z5Odz5YOvfR6u3ffFKnsOWYUcjDW6b-" });
            _products.Add(new Product(){Name = "Pão Kids", Description = "Preço referente a unidade.", Price = 5.0, Type = "Pães", URL = "https://blog-cdn.eduk.com.br/wp-content/uploads/sites/3/2017/12/13123757/p%C3%A3o-caseiro-1.jpg" });

            _products.Add(new Product(){Name = "Leite Integral - Fazenda", Description = "Preço referente a unidade.", Price = 6.5, Type = "Bebidas", URL = "https://savegnago.vteximg.com.br/arquivos/ids/296490-1000-1000/18836-LEITE-FAZENDA-1L-TIPO-A-DESNATADO-LIGHT.jpg?v=636941288701800000" });
            _products.Add(new Product(){Name = "Coca-cola", Description = "Preço referente a unidade.", Price = 3.5, Type = "Bebidas", URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRfezL6cLTa5ix1o51MY-L1fO0HiwK0fUNkuOQSALAbLbDEQk_Q" });

            _products.Add(new Product(){Name = "Carolina", Description = "Preço referente a 100 gramas.", Price = 4.0, Type = "Diversos", URL = "https://img.itdg.com.br/tdg/images/recipes/000/164/633/307212/307212_original.jpg?mode=crop&width=710&height=400" });
            _products.Add(new Product(){Name = "Mateiga Aviação", Description = "Preço referente a unidade.", Price = 7.0, Type = "Diversos", URL = "https://static.carrefour.com.br/medias/sys_master/images/images/h8b/h9c/h00/h00/9445916147742.jpg" });
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Product não localizado.");

            }else if (_products.Any(x => x.Name == item.Name))
            {
                return null;
            }
            
            _products.Add(item);
            return item;
        }

        public IEnumerable<Product> GetAllByType(string type)
        {
            return _products.Where(p => p.Type == type);
        }

        public Product Get(string name)
        {
            return _products.Find(p => p.Name == name);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public void Remove(string name)
        {
            _products.RemoveAll(p => p.Name == name);
        }

        public Product Update(string name, Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Pruduto não pode ser nulo.");
            }

            int index = _products.FindIndex(p => p.Name == name);

            if (index == -1)
            {
                throw new ArgumentNullException("Product não localizado.");
            }
            _products.RemoveAt(index);
            _products.Add(item);
            return item;
        }
    }
}