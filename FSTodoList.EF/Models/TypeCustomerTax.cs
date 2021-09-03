using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeCustomerTax
    {
        public TypeCustomerTax()
        {
            XrefCustomerAddresses = new HashSet<XrefCustomerAddress>();
        }

        public int CustomerTaxTypeId { get; set; }
        public string TaxCode { get; set; }
        public decimal TaxPercentage { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<XrefCustomerAddress> XrefCustomerAddresses { get; set; }
    }
}
