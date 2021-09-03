using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
            XrefVendorAddresses = new HashSet<XrefVendorAddress>();
            XrefVendorContacts = new HashSet<XrefVendorContact>();
        }

        public int VendorId { get; set; }
        public int PaymentTermsTypeId { get; set; }
        public int ShippingCodeTypeId { get; set; }
        public int AccountCodeId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string CommentsAbout { get; set; }
        public string CommentsTo { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeVendorAccountCode AccountCode { get; set; }
        public virtual TypePaymentTerm PaymentTermsType { get; set; }
        public virtual TypeShippingCode ShippingCodeType { get; set; }
        public virtual TypeVendorStatus Status { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<XrefVendorAddress> XrefVendorAddresses { get; set; }
        public virtual ICollection<XrefVendorContact> XrefVendorContacts { get; set; }
    }
}
