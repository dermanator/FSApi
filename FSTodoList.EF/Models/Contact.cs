using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Orders = new HashSet<Order>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            Quotes = new HashSet<Quote>();
            XrefCustomerContacts = new HashSet<XrefCustomerContact>();
            XrefVendorContacts = new HashSet<XrefVendorContact>();
        }

        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public string BusinessPhone { get; set; }
        public string PhoneExt { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeContact ContactType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<XrefCustomerContact> XrefCustomerContacts { get; set; }
        public virtual ICollection<XrefVendorContact> XrefVendorContacts { get; set; }
    }
}
