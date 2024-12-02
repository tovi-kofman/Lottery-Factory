using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using MyProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Data.Repository
{
    public class LotteryRepository : ILotteryRepository
    {
        readonly DataContext<Lottery> _dataContext;

        public LotteryRepository(DataContext<Lottery> dataContext)
        {
            _dataContext = dataContext;
        }

        public bool AddLottery(Lottery lottery)
        {
            _dataContext.db.Add(lottery);
            return _dataContext.SaveData(_dataContext.db);
        }

        public List<Lottery> GetLotteries()
        {
            return _dataContext.db;
        }

        public Lottery GetLotteryById(int id)
        {
            return _dataContext.db.FirstOrDefault(x => x.LotteryId == id);
        }

        public bool RemoveLottery(int id)
        {
            var lotteries = _dataContext.db;
            lotteries.Remove(lotteries.FirstOrDefault(x => x.LotteryId == id));
            return _dataContext.SaveData<Lottery>(lotteries);
        }

        public bool UpdateLottery(int id, Lottery lottery)
        {
            var lotteries = _dataContext.db;
            foreach (var l in lotteries)
            {
                if (l.LotteryId == lottery.LotteryId)
                {
                    l.TicketPrice = lottery.TicketPrice;
                    l.TicketSalesChannel = lottery.TicketSalesChannel;
                    l.TicketSalesDeadline = lottery.TicketSalesDeadline;
                    l.StartDate = lottery.StartDate;
                    l.EndDate = lottery.EndDate;
                    l.DrawFrequency = lottery.DrawFrequency;
                    l.JackpotAmount = lottery.JackpotAmount;
                    l.WinningsAmount = lottery.WinningsAmount;
                    l.OddsOfWinning = lottery.OddsOfWinning;
                    l.LotteryType = lottery.LotteryType;
                    return _dataContext.SaveData(lotteries);
                }
            }
            return false;
        }
    }
}
