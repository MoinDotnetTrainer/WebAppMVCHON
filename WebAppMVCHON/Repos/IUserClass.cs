using Microsoft.EntityFrameworkCore;
using WebAppMVCHON.Models;

namespace WebAppMVCHON.Repos
{
    public class IUserClass : IUserInterface
    {
        public readonly DatabaseContext _context;
        public IUserClass(DatabaseContext context) { _context = context; }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task InsertUser(Users users)
        {
            await _context.Users.AddAsync(users);
        }


        public async Task<Users?> GetUserbyID(int UserId)
        {
            var users = await _context.Users.FirstOrDefaultAsync(x => x.UserId == UserId);
            return users;
        }


        public async Task UpdateUsers(Users users)
        {
            _context.Users.Update(users);
        }


        public async Task DeleteUsers(int UserId)
        {

            var res = await _context.Users.FindAsync(UserId);
            if (res != null)
            {
                _context.Users.Remove(res);
            }
        }

        public bool Login(LoginModel obj)
        {
            bool res = _context.Users.Any(x => x.Email == obj.EmailId && x.Password == obj.Password);
            return res;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
