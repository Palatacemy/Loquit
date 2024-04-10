using Loquit.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Evaluations = [0, 0, 0, 0, 0];
            IsEdited = false;
            IsNsfw = false;
            IsSpoiler = false;
        }
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string PictureUrl { get; set; }
        public string CreatorId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public int CategoryId { get; set; }
        public double[] Evaluations { get; set; }
        public bool IsSpoiler { get; set; }
        public bool IsNsfw { get; set; }
        public bool IsEdited { get; set; }
    }
}
