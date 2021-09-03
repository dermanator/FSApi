using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefCustomerContact
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public sbyte IsPrimary { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
