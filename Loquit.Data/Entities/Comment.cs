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
        public string Text { get; set; }
        public AppUser? Commenter { get; set; }
        public DateTime TimeOfCommenting { get; set; }

    }
}
