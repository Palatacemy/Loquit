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
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string PictureUrl { get; set; }
        public AppUser Creator { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public List<Comment>? Comments { get; set; }

    }
}
