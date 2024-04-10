﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs.AbstracionsDTOs
{
    public abstract class BaseMessageDTO : BaseDTO
    {
        public DateTime TimeOfSending { get; set; }
        public string SenderUserId { get; set; }
    }
}
