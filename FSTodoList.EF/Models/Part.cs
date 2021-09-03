using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Part
    {
        public Part()
        {
            InProcessOperations = new HashSet<InProcessOperation>();
            Jobs = new HashSet<Job>();
            PartHardwares = new HashSet<PartHardware>();
            PartRoutes = new HashSet<PartRoute>();
            XrefQuoteParts = new HashSet<XrefQuotePart>();
        }

        public int PartId { get; set; }
        public int PartTypeId { get; set; }
        public string PartNumber { get; set; }
        public string Revision { get; set; }
        public int? Features { get; set; }
        public int? Setups { get; set; }
        public int? TightTolerances { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? QuotePrice { get; set; }
        public decimal? CalculatedPrice { get; set; }
        public string HighRezImage { get; set; }
        public string LowRezImage { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int? FixtureLocationId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Bin FixtureLocation { get; set; }
        public virtual TypePart PartType { get; set; }
        public virtual ICollection<InProcessOperation> InProcessOperations { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<PartHardware> PartHardwares { get; set; }
        public virtual ICollection<PartRoute> PartRoutes { get; set; }
        public virtual ICollection<XrefQuotePart> XrefQuoteParts { get; set; }
    }
}
