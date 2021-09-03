using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public int? PackingListId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? InvoiceTaxTypeId { get; set; }
        public int? PaymentTermsTypeId { get; set; }
        public decimal? Tax { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal? InvoiceSubTotal { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public int InvoiceStatusId { get; set; }
        public string EmailAddress { get; set; }
        public string Notes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeCustomerInvoiceStatus InvoiceStatus { get; set; }
        public virtual PackingList PackingList { get; set; }
        public virtual TypePaymentTerm PaymentTermsType { get; set; }
    }
}
