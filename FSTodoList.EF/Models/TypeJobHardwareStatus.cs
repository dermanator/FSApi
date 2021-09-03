using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeJobHardwareStatus
    {
        public TypeJobHardwareStatus()
        {
            JobHardwares = new HashSet<JobHardware>();
        }

        public int JobHardwareStatusId { get; set; }
        public string JobHardwareStatus { get; set; }

        public virtual ICollection<JobHardware> JobHardwares { get; set; }
    }
}
