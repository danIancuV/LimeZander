using Data.LimeZander.Model;
using Data.LimeZander.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.LimeZander.Persistence.Repositories.Implementation
{

    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(LimeZanderContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.AsEnumerable();
        }

        public IEnumerable<Product> GetProductTypes(ProductType productType)
        {
            return _context.Products.Where(x => x.ProductType == productType).AsEnumerable();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
