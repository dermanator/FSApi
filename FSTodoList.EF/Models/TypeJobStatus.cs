using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeJobStatus
    {
        public TypeJobStatus()
        {
            Jobs = new HashSet<Job>();
        }

        public int JobStatusTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
