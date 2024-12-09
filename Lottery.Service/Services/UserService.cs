using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
namespace LotteryFactory.Service.Services
{
    public class UserService : IUserService
    {
        readonly IRepository<User> _userRepository;
        readonly IRepositoryManager<User> _userManager;
        public UserService(IRepository<User> userRepository, IRepositoryManager<User> userManager)
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
                _userManager.Save();
                return _userRepository.Add(user);
            }
            return null;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll();
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
            return _userRepository.Update(id, user);
        }
    }
}
