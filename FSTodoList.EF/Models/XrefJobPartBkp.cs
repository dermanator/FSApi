using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefJobPartBkp
    {
        public int JobPartId { get; set; }
        public int JobId { get; set; }
        public int PartId { get; set; }
        public int JobPartStatusId { get; set; }
        public int Quantity { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
