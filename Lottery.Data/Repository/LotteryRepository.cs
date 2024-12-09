//using LotteryFactory.Core.Entities;
//using LotteryFactory.Core.InterfaceRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LotteryFactory.Data.Repository
//{
//    public class LotteryRepository : ILotteryRepository
//    {
//        readonly DataContext _dataContext;

//        public LotteryRepository(DataContext dataContext)
//        {
//            _dataContext = dataContext;
//        }

//        public Lottery AddLottery(Lottery lottery)
//        {
//            _dataContext.Lotteries.Add(lottery);
//             _dataContext.SaveChanges();
//            return lottery;
//        }

//        public List<Lottery> GetLotteries()
//        {
//            return _dataContext.Lotteries;
//        }

//        public Lottery GetLotteryById(int id)
//        {
//            return _dataContext.Lotteries.FirstOrDefault(x => x.LotteryId == id);
//        }

//        public bool RemoveLottery(int id)
//        {
//            var lotteries = _dataContext.Lotteries;
//            lotteries.Remove(lotteries.FirstOrDefault(x => x.LotteryId == id));
//             _dataContext.SaveChanges();
//            return true;////////////////
//        }

//        public bool UpdateLottery(int id, Lottery lottery)
//        {
//            var lotteries = _dataContext.Lotteries;
//            foreach (var l in lotteries)
//            {
//                if (l.LotteryId == lottery.LotteryId)
//                {
//                    l.TicketPrice = lottery.TicketPrice;
//                    l.TicketSalesChannel = lottery.TicketSalesChannel;
//                    l.TicketSalesDeadline = lottery.TicketSalesDeadline;
//                    l.StartDate = lottery.StartDate;
//                    l.EndDate = lottery.EndDate;
//                    l.DrawFrequency = lottery.DrawFrequency;
//                    l.JackpotAmount = lottery.JackpotAmount;
//                    l.WinningsAmount = lottery.WinningsAmount;
//                    l.OddsOfWinning = lottery.OddsOfWinning;
//                    l.LotteryType = lottery.LotteryType;
//                    _dataContext.SaveChanges();
//                    return true;/////////////
//                }
//            }
//            return false;
//        }

       
//    }
//}
