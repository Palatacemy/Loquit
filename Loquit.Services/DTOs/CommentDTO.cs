using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs
{
    public class CommentDTO
    {
        public string Text { get; set; }
        public int CommenterId { get; set; }
        public DateTime TimeOfCommenting { get; set; }
    }
}
