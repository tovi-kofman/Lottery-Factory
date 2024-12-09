using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Core.InterfaceRepository
{
    public interface IRepositoryManager<T> where T : class
    {
         IRepository<T> Repository { get; }
        void Save();
    }
}
