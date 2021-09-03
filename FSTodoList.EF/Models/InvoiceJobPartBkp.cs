using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class InvoiceJobPartBkp
    {
        public int InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public int JobPartId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
