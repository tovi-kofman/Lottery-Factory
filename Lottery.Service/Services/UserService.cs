using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
namespace LotteryFactory.Service.Services
{
    public class UserService : IUserService
    {
        readonly IRepository<User> _userRepository;
        readonly IRepositoryManager _userManager;
        public UserService(IRepository<User> userRepository, IRepositoryManager userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public User AddUser(User user)
        {
            TzValid tzValid = new TzValid();
            ErrorTZ error;
            if (tzValid.ISOK(user.Tz, out error))
            {
                User u= _userRepository.Add(user); ;
                _userManager.Save();
                return u; 
            }
            return null;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll(u=>u.Tickets);
        }

        public bool RemoveUser(int id)
        {

            if (_userRepository.Delete(id))
            {
                _userManager.Save();
                return true;
            }
            return false;
        }

        public User UpdateUser(int id, User user)
        {
            User u= _userRepository.Update(id, user);
            _userManager.Save();
            return u;
        }
    }
}
