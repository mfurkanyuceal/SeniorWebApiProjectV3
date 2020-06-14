using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeniorWebAPIProjectV3.DBContext;
using SeniorWebAPIProjectV3.Models;

namespace SeniorWebAPIProjectV3.Services
{
    public interface IUserService
    {
        public Task<bool> AddUserAsync(User user);
        public Task<List<User>> GetUserListAsync();
        public Task<bool> UpdateUserListAsync(List<User> userList);
        public Task<List<User>> SearchUserByFancyNameAsync(string fancyName);
        public Task<List<User>> SearchUserByAbilityNameAsync(string abilityName);
        public Task<User> GetUserByUserIdAsync(string userId);
        public Task<User> GetUserByUserNameAsync(string userName);
        public Task<bool> UpdateUserAsync(User user);
        public Task<bool> DeleteUserByUserIdAsync(string userId);
    }

    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            await _dataContext.Users.AddAsync(user);

            var created = await _dataContext.SaveChangesAsync();

            return created > 0;
        }

        public async Task<List<User>> GetUserListAsync()
        {
            return await _dataContext.Users.ToListAsync();
        }

        public async Task<bool> UpdateUserListAsync(List<User> userList)
        {
            _dataContext.Users.UpdateRange(userList);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<List<User>> SearchUserByFancyNameAsync(string fancyName)
        {
            var resultList =
                await _dataContext.Users.Where(user => user.userFancies.Contains(fancyName)).ToListAsync();

            return resultList;
        }

        public async Task<List<User>> SearchUserByAbilityNameAsync(string abilityName)
        {
            var resultList =
                await _dataContext.Users.Where(user => user.userAbilities.Contains(abilityName)).ToListAsync();

            return resultList;
        }

        public async Task<User> GetUserByUserIdAsync(string userId)
        {
            var user =
                await _dataContext.Users.SingleOrDefaultAsync(user1 => user1.userID == userId);
            return user;
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            var user =
                await _dataContext.Users.SingleOrDefaultAsync(user1 => user1.userName == userName);
            return user;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            _dataContext.Users.Update(user);

            var updated = await _dataContext.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<bool> DeleteUserByUserIdAsync(string userId)
        {
            var user = await GetUserByUserIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            _dataContext.Users.Remove(user);

            var deleted = await _dataContext.SaveChangesAsync();

            return deleted > 0;
        }
    }
}