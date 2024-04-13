﻿using Loquit.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities
{
    public class Dislike : BaseEntity
    {
        public int? PostId { get; set; }
        public virtual Post? Post { get; set; }
        public int? CommentId { get; set; }
        public virtual Comment? Comment { get; set; }
        public string UserId { get; set; }
        public virtual AppUser? User { get; set; }
    }
}
