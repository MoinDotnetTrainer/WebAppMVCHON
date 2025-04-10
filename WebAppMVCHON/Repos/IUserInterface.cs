using WebAppMVCHON.Models;

namespace WebAppMVCHON.Repos
{
    public interface IUserInterface
    {
        //adstract methods

        // getting all user info 
        Task<IEnumerable<Users>> GetAllUsers();

        // inserting user info
        Task InsertUser(Users users);

        Task SaveAsync();
    }
}
