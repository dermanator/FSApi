using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeRmaStatus
    {
        public TypeRmaStatus()
        {
            Rmas = new HashSet<Rma>();
        }

        public int RmaStatusTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Rma> Rmas { get; set; }
    }
}
