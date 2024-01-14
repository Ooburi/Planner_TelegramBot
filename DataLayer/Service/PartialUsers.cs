using DataLayer.Interface;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Service
{
    public partial class AppService : IAppService
    {
        public async Task<User?> GetUser(long userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.TelegramUserId == userId);
        }
    }
}
