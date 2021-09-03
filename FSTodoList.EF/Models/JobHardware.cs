using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class JobHardware
    {
        public JobHardware()
        {
            ReceiverItems = new HashSet<ReceiverItem>();
            XrefJobItemPurchaseOrderItems = new HashSet<XrefJobItemPurchaseOrderItem>();
        }

        public int JobHardwareId { get; set; }
        public int JobId { get; set; }
        public int HardwareId { get; set; }
        public int JobHardwareStatusId { get; set; }
        public int? Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public ulong CertificationRequired { get; set; }
        public int? PartHardwareId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Hardware Hardware { get; set; }
        public virtual Job Job { get; set; }
        public virtual TypeJobHardwareStatus JobHardwareStatus { get; set; }
        public virtual ICollection<ReceiverItem> ReceiverItems { get; set; }
        public virtual ICollection<XrefJobItemPurchaseOrderItem> XrefJobItemPurchaseOrderItems { get; set; }
    }
}
