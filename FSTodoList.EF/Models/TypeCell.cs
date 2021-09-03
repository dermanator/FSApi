using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeCell
    {
        public TypeCell()
        {
            Cells = new HashSet<Cell>();
        }

        public int CellTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Cell> Cells { get; set; }
    }
}
