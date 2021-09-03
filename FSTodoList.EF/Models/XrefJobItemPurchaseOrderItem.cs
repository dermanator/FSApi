using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefJobItemPurchaseOrderItem
    {
        public int JobItemPurchaseOrderItemId { get; set; }
        public int? JobHardwareId { get; set; }
        public int? JobMaterialId { get; set; }
        public int? JobRouteId { get; set; }
        public int PurchaseOrderItemId { get; set; }
        public int? JobItemQuantity { get; set; }
        public int? JobQuantity { get; set; }
        public int? JobExtra { get; set; }
        public int? JobTotal { get; set; }
        public int? JobReceived { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual JobHardware JobHardware { get; set; }
        public virtual JobMaterial JobMaterial { get; set; }
        public virtual JobRoute JobRoute { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
    }
}
