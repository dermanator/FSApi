using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefVendorAddress
    {
        public int VendorId { get; set; }
        public int AddressId { get; set; }
        public sbyte IsPrimary { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
