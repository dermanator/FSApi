using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypePart
    {
        public TypePart()
        {
            Parts = new HashSet<Part>();
        }

        public int PartTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
