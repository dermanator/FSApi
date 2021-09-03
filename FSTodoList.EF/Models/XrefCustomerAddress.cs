using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefCustomerAddress
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int CustomerTaxTypeId { get; set; }
        public sbyte IsPrimary { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual TypeCustomerTax CustomerTaxType { get; set; }
    }
}
