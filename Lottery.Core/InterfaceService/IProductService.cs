using LotteryFactory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Core.InterfaceService
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public Product GetProductById(int id);

        public Product AddProduct(Product product);

        public Product UpdateProduct(int id, Product product);

        public bool RemoveProduct(int id);
       
    }
}
