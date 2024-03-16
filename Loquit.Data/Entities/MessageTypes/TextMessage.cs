using Loquit.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities.MessageTypes
{
    public class TextMessage : BaseMessage
    {
        public string Text { get; set; }
    }
}
