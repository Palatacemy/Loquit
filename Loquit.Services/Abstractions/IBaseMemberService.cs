using Loquit.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Abstractions
{
    public interface IBaseMemberService
    {
        Task<List<BaseMemberDTO>> GetBaseMembersAsync();
        Task<BaseMemberDTO> GetBaseMemberByIdAsync(int id);
        Task AddBaseMemberAsync(BaseMemberDTO baseMember);
        Task DeleteBaseMemberByIdAsync(int id);
        Task UpdateBaseMemberAsync(BaseMemberDTO baseMember);
    }
}
