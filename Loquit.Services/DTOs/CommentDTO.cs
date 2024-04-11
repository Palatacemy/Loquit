﻿using Loquit.Data.Entities;
using Loquit.Services.DTOs.AbstracionsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs
{
    public class CommentDTO : BaseDTO
    {
        public CommentDTO()
        {
            IsEdited = false;
        }
        public string Text { get; set; }
        public virtual AppUser? Commenter { get; set; }
        public DateTime TimeOfCommenting { get; set; }
        public bool IsEdited { get; set; }
    }
}
