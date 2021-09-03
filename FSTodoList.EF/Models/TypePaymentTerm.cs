using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypePaymentTerm
    {
        public TypePaymentTerm()
        {
            Customers = new HashSet<Customer>();
            Invoices = new HashSet<Invoice>();
            Orders = new HashSet<Order>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            Quotes = new HashSet<Quote>();
            VendorInvoices = new HashSet<VendorInvoice>();
            Vendors = new HashSet<Vendor>();
        }

        public int PaymentTermsTypeId { get; set; }
        public string Value { get; set; }
        public string DisplayValue { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<VendorInvoice> VendorInvoices { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
