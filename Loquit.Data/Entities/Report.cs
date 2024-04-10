using Loquit.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Entities
{
    public class Report : BaseEntity
    {
        public string ReportingUserId { get; set; }
        public string ReportedUserId { get; set; }
        public string AttachedText { get; set; }
        public BaseMessage? ReportedMessage { get; set; }
        public Post? ReportedPost { get; set; }
        public Comment? ReportedComment { get; set; }
    }
}
