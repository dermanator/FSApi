using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class JobRoute
    {
        public JobRoute()
        {
            ReceiverItems = new HashSet<ReceiverItem>();
            XrefJobItemPurchaseOrderItems = new HashSet<XrefJobItemPurchaseOrderItem>();
        }

        public int JobRouteId { get; set; }
        public int? RouteId { get; set; }
        public int JobId { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public int RouteTypeId { get; set; }
        public decimal? SetupTime { get; set; }
        public decimal? CycleTime { get; set; }
        public decimal? LeadTime { get; set; }
        public decimal? OutsourceTime { get; set; }
        public decimal? OutsourceUnitCost { get; set; }
        public int UnitCount { get; set; }
        public int? PartRouteId { get; set; }
        public int? PoquantityExtra { get; set; }
        public int? PoquantityTotal { get; set; }
        public ulong CertificationRequired { get; set; }
        public string OperationalNotes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Job Job { get; set; }
        public virtual Route Route { get; set; }
        public virtual TypeRoute RouteType { get; set; }
        public virtual ICollection<ReceiverItem> ReceiverItems { get; set; }
        public virtual ICollection<XrefJobItemPurchaseOrderItem> XrefJobItemPurchaseOrderItems { get; set; }
    }
}
