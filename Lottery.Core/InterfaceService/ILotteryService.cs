
using LotteryFactory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Core.InterfaceService
{
    public interface ILotteryService
    {
        List<Lottery> GetLotteries();
        Lottery GetLotteryById(int id);
        Lottery AddLottery(Lottery lottery);
        Lottery UpdateLottery(int id, Lottery lottery);
        bool RemoveLottery(int id);
    }
}
