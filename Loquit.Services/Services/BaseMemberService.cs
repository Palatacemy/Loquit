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

        public async Task AddBaseMemberAsync(BaseMemberDTO model)
        {
            var baseMember = _mapper
                .Map<BaseMember>(model);

            await _baseMemberRepository.AddAsync(baseMember);
        }

        public async Task<BaseMemberDTO> GetBaseMemberByIdAsync(int id)
        {
            var baseMember = await _baseMemberRepository.GetByIdAsync(id);
            return _mapper.Map<BaseMemberDTO>(baseMember);
        }

        public async Task UpdateBaseMemberAsync(BaseMemberDTO model)
        {
            var baseMember = _mapper.Map<BaseMember>(model);
            await _baseMemberRepository.UpdateAsync(baseMember);
        }
    }
}
