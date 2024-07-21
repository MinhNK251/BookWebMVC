using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Product product)
        {
            var existingProduct = _context.Products.FirstOrDefault(u => u.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Title = product.Title;
                existingProduct.Description = product.Description;
                existingProduct.ISBN = product.ISBN;
                existingProduct.Author = product.Author;
                existingProduct.ListPrice = product.ListPrice;
                existingProduct.Price = product.Price;
                existingProduct.Price50 = product.Price50;
                existingProduct.Price100 = product.Price100;
                if (existingProduct.ImageUrl != null)
                {
                    existingProduct.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
