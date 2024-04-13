using Loquit.Services.DTOs.AbstracionsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.DTOs.MessageTypesDTOs
{
    //DTO for ImageMessage; inherits from BaseMessageDTO
    public class ImageMessageDTO : BaseMessageDTO
    {
        public string PictureUrl { get; set; }
    }
}
