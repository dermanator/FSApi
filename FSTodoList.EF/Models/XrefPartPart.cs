using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefPartPart
    {
        public int PartId { get; set; }
        public int SubPartId { get; set; }
        public int Quantity { get; set; }
    }
}
