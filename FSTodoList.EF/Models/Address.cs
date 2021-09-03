using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Address
    {
        public Address()
        {
            Orders = new HashSet<Order>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            Quotes = new HashSet<Quote>();
            XrefCustomerAddresses = new HashSet<XrefCustomerAddress>();
            XrefVendorAddresses = new HashSet<XrefVendorAddress>();
        }

        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeAddress AddressType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<XrefCustomerAddress> XrefCustomerAddresses { get; set; }
        public virtual ICollection<XrefVendorAddress> XrefVendorAddresses { get; set; }
    }
}
