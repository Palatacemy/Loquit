﻿using Loquit.Data.Entities.Abstractions;
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
            IsEdited = false;
        }
        public string Text { get; set; }
        public string CommenterId { get; set; }
        public DateTime TimeOfCommenting { get; set; }
        public bool IsEdited { get; set; }

    }
}
