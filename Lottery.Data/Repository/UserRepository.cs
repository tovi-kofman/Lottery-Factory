using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;

namespace LotteryFactory.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        readonly DataContext<User> _dataContext;

        public UserRepository(DataContext<User> dataContext)
        {
            _dataContext = dataContext;
        }

        public bool AddUser(User user)
        {
             _dataContext.db.Add(user);
            return _dataContext.SaveData<User>(_dataContext.db);
        }

        public User GetUserById(int id)
        {
            return _dataContext.db.FirstOrDefault(x => x.UserId == id);
        }

        public List<User> GetUsers()
        {
            return _dataContext.db;
        }

        public bool RemoveUser(int id)
        {
            var users = _dataContext.db;
            users.Remove(users.FirstOrDefault(x => x.UserId == id));
            return _dataContext.SaveData<User>(users);
        }

        public bool UpdateUser(int id, User user)
        {
            var users = _dataContext.db;
            foreach (User u in users)
            {
                if (u.UserId == id)
                {
                    u.Address = user.Address;
                    u.Password = user.Password;
                    u.Email = user.Email;
                    u.FirstName = user.FirstName;
                    u.LastName = user.LastName;
                    u.PhoneNumber = user.PhoneNumber;
                    u.AccountType = user.AccountType;

                    return _dataContext.SaveData<User>(users);
                }
            }
            return false;
        }
    }
}
