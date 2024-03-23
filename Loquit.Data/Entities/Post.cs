﻿using Loquit.Data.Entities.Abstractions;
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
        }
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string PictureUrl { get; set; }
        public int CreatorId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public ICollection<Comment>? Comments { get; set; }

    }
}
