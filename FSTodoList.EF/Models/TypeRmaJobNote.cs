using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeRmaJobNote
    {
        public TypeRmaJobNote()
        {
            RmaJobNotes = new HashSet<RmaJobNote>();
        }

        public int RmaJobNoteTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<RmaJobNote> RmaJobNotes { get; set; }
    }
}
