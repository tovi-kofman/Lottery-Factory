using LotteryFactory.Core.Entities;

namespace LotteryFactory.Core.InterfaceService
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(int id);
        bool AddUser(User user);
        bool UpdateUser(int id, User user);
        bool RemoveUser(int id);
    }
}
