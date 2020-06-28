using Data.LimeZander.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.LimeZander.Persistence.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);
    }
}
