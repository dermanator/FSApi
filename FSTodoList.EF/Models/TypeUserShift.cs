using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeUserShift
    {
        public TypeUserShift()
        {
            Users = new HashSet<User>();
        }

        public int ShiftId { get; set; }
        public string ShiftValue { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
