using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            Quotes = new HashSet<Quote>();
            XrefCustomerAddresses = new HashSet<XrefCustomerAddress>();
            XrefCustomerContacts = new HashSet<XrefCustomerContact>();
        }

        public int CustomerId { get; set; }
        public int PaymentTermsTypeId { get; set; }
        public string Name { get; set; }
        public string CustomerCode { get; set; }
        public int CustomerTypeId { get; set; }
        public string EmailAddress { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }

        public virtual TypeCustomer CustomerType { get; set; }
        public virtual TypePaymentTerm PaymentTermsType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<XrefCustomerAddress> XrefCustomerAddresses { get; set; }
        public virtual ICollection<XrefCustomerContact> XrefCustomerContacts { get; set; }
    }
}
