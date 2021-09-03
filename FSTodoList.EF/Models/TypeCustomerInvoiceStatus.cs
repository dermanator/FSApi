using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeCustomerInvoiceStatus
    {
        public TypeCustomerInvoiceStatus()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int CustomerInvoiceStatusTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
