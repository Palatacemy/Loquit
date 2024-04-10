using Loquit.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs.AbstracionsDTOs
{
    public abstract class BaseChatDTO : BaseDTO
    {
        public List<AppUser> Members { get; set; }
        public List<BaseMessageDTO>? Messages { get; set; }
    }
}
