using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities.Abstractions
{
    public abstract class BaseMember : BaseEntity 
    {
        public int UserId { get; set; }
        public int UserIdInChat { get; set; }
    }
}
