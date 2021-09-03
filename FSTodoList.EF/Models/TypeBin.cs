using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeBin
    {
        public TypeBin()
        {
            Bins = new HashSet<Bin>();
        }

        public int BinTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Bin> Bins { get; set; }
    }
}
