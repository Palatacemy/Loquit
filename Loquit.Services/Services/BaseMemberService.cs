using AutoMapper;
using Loquit.Data.Entities;
using Loquit.Data.Repositories.Abstractions;
using Loquit.Services.Abstractions;
using Loquit.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Services
{
    public class BaseMemberService : IBaseMemberService
    {
        private readonly ICrudRepository<BaseMember> _baseMemberRepository;
        private readonly IMapper _mapper;
        public BaseMemberService(ICrudRepository<BaseMember> baseMemberRepository, IMapper mapper)
        {
            _baseMemberRepository = baseMemberRepository;
            _mapper = mapper;
        }

        public Task AddBaseMemberAsync(BaseMemberDTO baseMember)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBaseMemberByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseMemberDTO> GetBaseMemberByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BaseMemberDTO>> GetBaseMembersAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBaseMemberAsync(BaseMemberDTO baseMember)
        {
            throw new NotImplementedException();
        }
    }
}
