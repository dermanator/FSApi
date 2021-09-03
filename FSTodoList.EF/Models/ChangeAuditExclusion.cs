using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class ChangeAuditExclusion
    {
        public int ChangeAuditExclusionId { get; set; }
        public string EntityName { get; set; }
        public string PropertyName { get; set; }
    }
}
