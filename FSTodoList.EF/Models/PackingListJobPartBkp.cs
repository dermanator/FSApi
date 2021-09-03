using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PackingListJobPartBkp
    {
        public int PackingListItemId { get; set; }
        public int PackingListId { get; set; }
        public int JobPartId { get; set; }
        public int PackedQty { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
