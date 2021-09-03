using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeVendorStatus
    {
        public TypeVendorStatus()
        {
            Vendors = new HashSet<Vendor>();
        }

        public int StatusId { get; set; }
        public string StatusValue { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
