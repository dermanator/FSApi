using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class HardwareBkp20190828
    {
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
    }
}
