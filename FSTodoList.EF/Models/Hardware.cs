using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Hardware
    {
        public Hardware()
        {
            JobHardwares = new HashSet<JobHardware>();
            PartHardwares = new HashSet<PartHardware>();
        }

        public int HardwareId { get; set; }
        public string PartNumber { get; set; }
        public string HardwareDescription { get; set; }
        public decimal? Price { get; set; }
        public int? UnitCount { get; set; }
        public string UnitOfMeasure { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<JobHardware> JobHardwares { get; set; }
        public virtual ICollection<PartHardware> PartHardwares { get; set; }
    }
}
