using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
namespace LotteryFactory.Service.Services
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool AddUser(User user)
        {
            TzValid tzValid = new TzValid();
            ErrorTZ error;
            if (tzValid.ISOK(user.Tz, out error))
            {
                return _userRepository.AddUser(user);
            }
            return false;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public bool RemoveUser(int id)
        {
            return (_userRepository.RemoveUser(id));
        }

        public bool UpdateUser(int id, User user)
        {
            return _userRepository.UpdateUser(id, user);
        }
    }
}
