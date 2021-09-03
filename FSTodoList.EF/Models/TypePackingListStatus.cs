using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypePackingListStatus
    {
        public TypePackingListStatus()
        {
            PackingLists = new HashSet<PackingList>();
        }

        public int PackingListStatusId { get; set; }
        public string StatusValue { get; set; }
        public int DisplayOrder { get; set; }
        public string StatusDisplayName { get; set; }

        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
