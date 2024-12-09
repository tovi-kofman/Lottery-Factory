using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Data.Repository
{
    public class RepositoryManager<T>: IRepositoryManager<T> where T : class 
    {
        private readonly DataContext _dataContext;
        public IRepository<T> Repository { get; }
        public RepositoryManager(DataContext context, IRepository<T> repository)
        {
            _dataContext = context;
            Repository = repository;
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
