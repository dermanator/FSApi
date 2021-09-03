using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class VwJobTimeDatum
    {
        public string JobNumber { get; set; }
        public string PartNumber { get; set; }
        public string Revision { get; set; }
        public int? Quantity { get; set; }
        public DateTime? DueDate { get; set; }
        public int JobStatusTypeId { get; set; }
        public string HighRezImage { get; set; }
    }
}
