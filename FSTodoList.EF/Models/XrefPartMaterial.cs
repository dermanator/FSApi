using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefPartMaterial
    {
        public XrefPartMaterial()
        {
            PartMaterialQuoteEstimates = new HashSet<PartMaterialQuoteEstimate>();
        }

        public int PartMaterialId { get; set; }
        public int PartId { get; set; }
        public int? MaterialId { get; set; }
        public string Length { get; set; }
        public int? Quantity { get; set; }
        public decimal? PricePerUnit { get; set; }
        public ulong CertificationRequired { get; set; }
        public decimal? CostEstimate { get; set; }
        public int? RawMaterialTypeId { get; set; }
        public int UnitCount { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Diameter { get; set; }
        public string MaterialDescription { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeRawMaterial RawMaterialType { get; set; }
        public virtual ICollection<PartMaterialQuoteEstimate> PartMaterialQuoteEstimates { get; set; }
    }
}
