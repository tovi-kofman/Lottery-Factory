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
    public class LotteryService : ILotteryService
    {
        readonly IRepository<Lottery> _lotteryRepository;
        readonly IRepositoryManager<Lottery> _repositoryManager;
        public LotteryService(IRepository<Lottery> lotteryRepository)
        {
            _lotteryRepository = lotteryRepository;
        }

        public Lottery AddLottery(Lottery lottery)
        {
            return _lotteryRepository.Add(lottery);
        }

        public List<Lottery> GetLotteries()
        {
            return _lotteryRepository.GetAll();
        }

        public Lottery GetLotteryById(int id)
        {
            return _lotteryRepository.GetById(id);
        }

        public bool RemoveLottery(int id)
        {
            return _lotteryRepository.Delete(id);
        }

        public Lottery UpdateLottery(int id, Lottery lottery)
        {
            return _lotteryRepository.Update(id,lottery);
        }
    }
}
