using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Bin
    {
        public Bin()
        {
            Parts = new HashSet<Part>();
            XrefJobMaterialBins = new HashSet<XrefJobMaterialBin>();
            XrefJobParts = new HashSet<XrefJobPart>();
            XrefPurchaseOrderItemBins = new HashSet<XrefPurchaseOrderItemBin>();
        }

        public int Id { get; set; }
        public string BinName { get; set; }
        public int BinTypeId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeBin BinType { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<XrefJobMaterialBin> XrefJobMaterialBins { get; set; }
        public virtual ICollection<XrefJobPart> XrefJobParts { get; set; }
        public virtual ICollection<XrefPurchaseOrderItemBin> XrefPurchaseOrderItemBins { get; set; }
    }
}
