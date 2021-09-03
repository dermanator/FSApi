using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class RmaJobNote
    {
        public int RmaJobNoteId { get; set; }
        public int RmaJobId { get; set; }
        public int RmaJobNoteTypeId { get; set; }
        public string Note { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual XrefRmaJob RmaJob { get; set; }
        public virtual TypeRmaJobNote RmaJobNoteType { get; set; }
    }
}
