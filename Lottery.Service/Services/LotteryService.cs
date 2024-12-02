using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
using MyProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Service.Services
{
    public class LotteryService : ILotteryService
    {
        readonly ILotteryRepository _lotteryRepository;

        public LotteryService(ILotteryRepository lotteryRepository)
        {
            _lotteryRepository = lotteryRepository;
        }

        public bool AddLottery(Lottery lottery)
        {
            return _lotteryRepository.AddLottery(lottery);
        }

        public List<Lottery> GetLotteries()
        {
            return _lotteryRepository.GetLotteries();
        }

        public Lottery GetLotteryById(int id)
        {
            return _lotteryRepository.GetLotteryById(id);
        }

        public bool RemoveLottery(int id)
        {
            return _lotteryRepository.RemoveLottery(id);
        }

        public bool UpdateLottery(int id, Lottery lottery)
        {
            return _lotteryRepository.UpdateLottery(id, lottery);
        }
    }
}
