using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeVendorAccountCode
    {
        public TypeVendorAccountCode()
        {
            Vendors = new HashSet<Vendor>();
        }

        public int AccountCodeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
