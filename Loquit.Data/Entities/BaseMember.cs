using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loquit.Data.Entities.Abstractions;

namespace Loquit.Data.Entities
{
    public class BaseMember : BaseEntity
    {
        public int UserId { get; set; }
    }
}
