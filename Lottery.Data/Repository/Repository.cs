using LotteryFactory.Core.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LotteryFactory.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public Repository(DataContext dataContext)
        {
            _dbSet =dataContext.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
           
            return entity;
        }

        public bool Delete(int id)
        {
             T entity=_dbSet.Find(id);
            if(entity == null) return false;
            _dbSet.Remove(entity);
            return true;
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {
           return _dbSet.Find(id);
        }

        public T Update(int id, T entity)
        {
            T myEntity = _dbSet.Find(id);

            if (myEntity != null)
            {
                Type entityType = typeof(T);
                PropertyInfo[] properties = entityType.GetProperties();

                foreach (PropertyInfo prop in properties)
                {
                    PropertyInfo entityProp = entityType.GetProperty(prop.Name);
                    if (entityProp != null)
                    {
                        object value = entityProp.GetValue(entity);
                        if (value != null)
                        {
                            entityProp.SetValue(myEntity, value);
                        }
                    }
                }

                _dbSet.Update(myEntity);
            }

            return myEntity;
        }

    }
}
