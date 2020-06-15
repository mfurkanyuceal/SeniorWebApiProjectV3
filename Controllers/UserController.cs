using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeniorWebAPIProjectV3.Models;
using SeniorWebAPIProjectV3.Services;

namespace SeniorWebAPIProjectV3.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<User>> GetUsers()
        {
            return await _userService.GetUserListAsync();
        }

        [HttpGet]
        public async Task<User> GetUser([FromRoute] string userId)
        {
            return await _userService.GetUserByUserIdAsync(userId);
        }
        
        [HttpGet]
        public async Task<User> GetUserByUserName([FromRoute] string userName)
        {
            return await _userService.GetUserByUserNameAsync(userName);
        }
        
        [HttpGet]
        public async Task<List<User>> GetUsersByFancy([FromRoute] string fancyName)
        {
            return await _userService.SearchUserByFancyNameAsync(fancyName);
        }
        
        [HttpGet]
        public async Task<List<User>> GetUsersByAbility([FromRoute] string abilityName)
        {
            return await _userService.SearchUserByAbilityNameAsync(abilityName);
        }

        [HttpPut]
        public async Task<User> Update([FromBody] User user)
        {
            var updated = await _userService.UpdateUserAsync(user);

            if (updated)
            {
                return await _userService.GetUserByUserIdAsync(user.Id);
            }

            return null;
        }

        [HttpDelete]
        public async Task<bool> Delete([FromRoute] string userId)
        {
            var deleted = await _userService.DeleteUserByUserIdAsync(userId);

            return deleted;
        }


        [HttpPost]
        public async Task<User> Create([FromBody] User user)
        {
            var created = await _userService.AddUserAsync(user);

            if (!created)
            {
                return null;
            }

            return await _userService.GetUserByUserIdAsync(user.Id);
        }
    }
}