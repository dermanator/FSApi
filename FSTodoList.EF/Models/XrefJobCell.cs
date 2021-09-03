using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefJobCell
    {
        public int JobCellId { get; set; }
        public int CellId { get; set; }
        public int JobId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Cell Cell { get; set; }
        public virtual Job Job { get; set; }
    }
}
