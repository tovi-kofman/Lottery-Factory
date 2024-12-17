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
    public class RepositoryManager: IRepositoryManager 
    {
        private readonly DataContext _dataContext;
        //public IRepository<T> Repository { get; }
        public RepositoryManager(DataContext context)
        {
            _dataContext = context;
            //Repository = repository;
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
