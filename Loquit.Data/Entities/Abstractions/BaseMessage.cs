using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities.Abstractions
{
    public abstract class BaseMessage : BaseEntity
    {
        public DateTime TimeOfSending { get; set; }
        public string SenderUserId { get; set; }
        public virtual AppUser? SenderUser { get; set; }
        public virtual BaseMessage? Parent { get; set; }
        public int ParentId { get; set; }
        public ICollection<BaseMessage> Replies { get; set; }
    }
}