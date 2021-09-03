using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class VendorInvoice
    {
        public VendorInvoice()
        {
            VendorInvoiceItems = new HashSet<VendorInvoiceItem>();
        }

        public int VendorInvoiceId { get; set; }
        public int? VendorInvoiceStatusId { get; set; }
        public string InvoiceNumber { get; set; }
        public int? PaymentTermsTypeId { get; set; }
        public int? VendorId { get; set; }
        public int? AddressId { get; set; }
        public decimal? InvoiceSubTotal { get; set; }
        public decimal? InvoiceTax { get; set; }
        public decimal? InvoiceShipping { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public string Notes { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypePaymentTerm PaymentTermsType { get; set; }
        public virtual TypeVendorInvoiceStatus VendorInvoiceStatus { get; set; }
        public virtual ICollection<VendorInvoiceItem> VendorInvoiceItems { get; set; }
    }
}
