using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Cell
    {
        public Cell()
        {
            Users = new HashSet<User>();
            XrefJobCells = new HashSet<XrefJobCell>();
            XrefJobPartStatusChangeHistoryNewCells = new HashSet<XrefJobPartStatusChangeHistory>();
            XrefJobPartStatusChangeHistoryOldCells = new HashSet<XrefJobPartStatusChangeHistory>();
            XrefJobParts = new HashSet<XrefJobPart>();
            XrefJobTimeEntries = new HashSet<XrefJobTimeEntry>();
        }

        public int CellId { get; set; }
        public int CellTypeId { get; set; }
        public string CellName { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeCell CellType { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<XrefJobCell> XrefJobCells { get; set; }
        public virtual ICollection<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistoryNewCells { get; set; }
        public virtual ICollection<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistoryOldCells { get; set; }
        public virtual ICollection<XrefJobPart> XrefJobParts { get; set; }
        public virtual ICollection<XrefJobTimeEntry> XrefJobTimeEntries { get; set; }
    }
}
