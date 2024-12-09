using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Service.Services
{
    public class ProductService : IProductService
    {
        readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public Product AddProduct(Product product)
        {
            return _productRepository.Add(product);
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public bool RemoveProduct(int id)
        {
           return _productRepository.Delete(id);
        }

        public Product UpdateProduct(int id, Product product)
        {
            return _productRepository.Update(id, product);
        }
    }
}
