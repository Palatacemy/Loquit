using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities.Abstractions
{
    public abstract class BaseChat : BaseEntity
    {
        public List<BaseMember> Members { get; set; }
        public List<BaseMessage>? Messages { get; set; }
    }
}
