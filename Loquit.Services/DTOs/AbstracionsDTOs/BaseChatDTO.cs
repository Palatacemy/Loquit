using Loquit.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs.AbstracionsDTOs
{
    //DTO for BaseChat; inherits from BaseDTO
    public abstract class BaseChatDTO : BaseDTO
    {
        public virtual List<AppUser> Members { get; set; }
        public virtual List<BaseMessageDTO>? Messages { get; set; }
    }
}
