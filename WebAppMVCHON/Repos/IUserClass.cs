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

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
