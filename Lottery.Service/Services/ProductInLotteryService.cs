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
    public class ProductInLotteryService : IProductInLotteryService
    {
        readonly IRepository<ProductInLottery> _productInLotteryRepository;

        public ProductInLotteryService(IRepository<ProductInLottery> productInLotteryRepository)
        {
            _productInLotteryRepository = productInLotteryRepository;
        }

        public ProductInLottery AddProductInLottery(ProductInLottery productInLottery)
        {
            return _productInLotteryRepository.Add(productInLottery);
        }

        public ProductInLottery AddProductInLottery(IProductInLotteryService productInLottery)
        {
            throw new NotImplementedException();
        }

        public ProductInLottery GetProductInLotteryById(int id)
        {
            return _productInLotteryRepository.GetById(id);
        }

        public List<ProductInLottery> GetProductsInLotteries()
        {
            return _productInLotteryRepository.GetAll();   
        }

        public bool RemoveProductInLottery(int id)
        {
            return _productInLotteryRepository.Delete(id);
        }

        public ProductInLottery UpdateProductInLottery(int id, ProductInLottery productInLottery)
        {
            return _productInLotteryRepository.Update(id, productInLottery);
        }


    }
}
