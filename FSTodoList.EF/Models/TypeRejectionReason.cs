using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeRejectionReason
    {
        public TypeRejectionReason()
        {
            XrefJobPartStatusChangeHistories = new HashSet<XrefJobPartStatusChangeHistory>();
        }

        public int RejectionReasonId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistories { get; set; }
    }
}
