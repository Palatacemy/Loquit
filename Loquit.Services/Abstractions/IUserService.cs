using Loquit.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Abstractions
{
    public interface IUserService
    {
        Task<List<AppUser>> GetAllUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser?> GetByUsernameAsync(string username);

        //methods, work in progress
        /*Task AddUserAsync(AppUser user);
        Task DeleteUserByIdAsync(int id);
        Task UpdateUserAsync(AppUser user);*/
    }
}
