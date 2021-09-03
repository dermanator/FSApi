using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class JobPartBatch
    {
        public JobPartBatch()
        {
            XrefJobParts = new HashSet<XrefJobPart>();
        }

        public int JobPartBatchId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<XrefJobPart> XrefJobParts { get; set; }
    }
}
