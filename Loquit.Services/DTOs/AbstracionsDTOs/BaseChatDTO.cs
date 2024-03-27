using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs.AbstracionsDTOs
{
    public abstract class BaseChatDTO : BaseDTO
    {
        public List<BaseMemberDTO> Members { get; set; }
        public List<BaseMessageDTO>? Messages { get; set; }
    }
}
