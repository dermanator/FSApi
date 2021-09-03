using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Receiver
    {
        public Receiver()
        {
            ReceiverItems = new HashSet<ReceiverItem>();
        }

        public int ReceiverId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<ReceiverItem> ReceiverItems { get; set; }
    }
}
