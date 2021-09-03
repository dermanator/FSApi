using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeJobPartStatus
    {
        public TypeJobPartStatus()
        {
            TypeAllowableJobPartStatuses = new HashSet<TypeAllowableJobPartStatus>();
            XrefJobPartStatusChangeHistoryNewJobPartStatuses = new HashSet<XrefJobPartStatusChangeHistory>();
            XrefJobPartStatusChangeHistoryOldJobPartStatuses = new HashSet<XrefJobPartStatusChangeHistory>();
            XrefJobParts = new HashSet<XrefJobPart>();
        }

        public int JobPartStatusId { get; set; }
        public string JobPartStatusValue { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }
        public ulong CanAssignCell { get; set; }
        public ulong IsCompletedStatus { get; set; }
        public ulong CanBeBatched { get; set; }

        public virtual ICollection<TypeAllowableJobPartStatus> TypeAllowableJobPartStatuses { get; set; }
        public virtual ICollection<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistoryNewJobPartStatuses { get; set; }
        public virtual ICollection<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistoryOldJobPartStatuses { get; set; }
        public virtual ICollection<XrefJobPart> XrefJobParts { get; set; }
    }
}
