using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PackingList
    {
        public PackingList()
        {
            Invoices = new HashSet<Invoice>();
            PackingListJobParts = new HashSet<PackingListJobPart>();
        }

        public int PackingListId { get; set; }
        public int OrderId { get; set; }
        public int PackingListStatusId { get; set; }
        public DateTime? ShipDate { get; set; }
        public string Notes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Order Order { get; set; }
        public virtual TypePackingListStatus PackingListStatus { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PackingListJobPart> PackingListJobParts { get; set; }
    }
}
