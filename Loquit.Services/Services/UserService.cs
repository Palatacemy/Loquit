using AutoMapper;
using Loquit.Data.Entities;
using Loquit.Data.Repositories.Abstractions;
using Loquit.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Services
{
    public class UserService : IUserService
    {
        private readonly ICrudRepository<AppUser> _userRepository;
        private readonly IMapper _mapper;
        public UserService(ICrudRepository<Post> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public Task<List<AppUser>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<AppUser>> GetAllUsersWithUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
