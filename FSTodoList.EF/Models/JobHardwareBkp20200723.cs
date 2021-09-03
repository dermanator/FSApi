using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class JobHardwareBkp20200723
    {
        public int JobHardwareId { get; set; }
        public int JobId { get; set; }
        public int HardwareId { get; set; }
        public int JobHardwareStatusId { get; set; }
        public int? Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public ulong CertificationRequired { get; set; }
        public int? PartHardwareId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
