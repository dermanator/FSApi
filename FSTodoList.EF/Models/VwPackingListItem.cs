using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class VwPackingListItem
    {
        public int PackingListId { get; set; }
        public int JobId { get; set; }
        public long Quantity { get; set; }
    }
}
