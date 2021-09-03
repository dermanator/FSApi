using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefJobMaterialBin
    {
        public int JobMaterialBinId { get; set; }
        public int JobMaterialId { get; set; }
        public int BinId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Bin Bin { get; set; }
        public virtual JobMaterial JobMaterial { get; set; }
    }
}
