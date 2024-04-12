using Loquit.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            Replies = new HashSet<Comment>();
            IsEdited = false;
            Likes = 0;
            Dislikes = 0;
            RepliesCount = 0;
        }
        public string Text { get; set; }
        public virtual AppUser? Commenter { get; set; }
        public DateTime TimeOfCommenting { get; set; }
        public bool IsEdited { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int RepliesCount { get; set; }
        public virtual Comment? Parent { get; set; }
        public int ParentId { get; set; }
        public ICollection<Comment>? Replies { get; set; }
    }
}
