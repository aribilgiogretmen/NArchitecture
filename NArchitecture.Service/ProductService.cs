using NArchitecture.Core.Entities;
using NArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArchitecture.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddProduct(Product product)
        {
           _unitOfWork.Products.Add(product);
           _unitOfWork.Complate();
        }

        public void DeleteProduct(int id)
        {
            var product = _unitOfWork.Products.Get(id);
            if (product != null)
            {

                _unitOfWork.Products.Remove(product);
                _unitOfWork.Complate();
            }
            
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _unitOfWork.Products.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _unitOfWork.Products.Get(id);
        }

        public IEnumerable<Product> SearchByProductName(string Name)
        {
            return _unitOfWork.Products.SearchByName(Name);
        }

        public void UpdateProduct(Product product)
        {
            var existingproduct = _unitOfWork.Products.Get(product.Id);
            if (existingproduct != null)
            {
                existingproduct.Name=product.Name;
                existingproduct.Price = product.Price;
                _unitOfWork.Complate();

            }
        }
    }
}
