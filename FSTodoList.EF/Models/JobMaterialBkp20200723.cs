using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class JobMaterialBkp20200723
    {
        public int JobMaterialId { get; set; }
        public int JobId { get; set; }
        public int? MaterialId { get; set; }
        public string Length { get; set; }
        public int JobMaterialStatusId { get; set; }
        public int? Quantity { get; set; }
        public ulong CertificationRequired { get; set; }
        public int? PartMaterialId { get; set; }
        public int? QuantityReceived { get; set; }
        public decimal PricePerUnit { get; set; }
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
    }
}
