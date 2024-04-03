using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs
{
    public class PostDTO
    {
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string PictureUrl { get; set; }
        public int CreatorId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public List<CommentDTO>? Comments { get; set; }
        public int CategoryId { get; set; }
        public bool IsSpoiler { get; set; }
        public bool IsNsfw { get; set; }
    }
}
