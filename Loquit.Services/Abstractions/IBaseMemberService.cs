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
        Task<BaseMemberDTO> GetBaseMemberByIdAsync(int id); //For testing/debugging purposes
        Task AddBaseMemberAsync(BaseMemberDTO baseMember);
        Task UpdateBaseMemberAsync(BaseMemberDTO baseMember);
    }
}
