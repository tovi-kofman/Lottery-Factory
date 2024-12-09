using LotteryFactory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Core.InterfaceService
{
    public interface IProductInLotteryService
    {
        public List<ProductInLottery> GetProductsInLotteries();

        public ProductInLottery GetProductInLotteryById(int id);
        public ProductInLottery AddProductInLottery(ProductInLottery productInLottery);
        public ProductInLottery UpdateProductInLottery(int id, ProductInLottery productInLottery);
       public bool RemoveProductInLottery(int id);
    }
}
