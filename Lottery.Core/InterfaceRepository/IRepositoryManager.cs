using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Core.InterfaceRepository
{
    public interface IRepositoryManager
    {
         //IRepository<T> Repository { get; }
        void Save();
    }
}
