using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Material
    {
        public Material()
        {
            JobMaterials = new HashSet<JobMaterial>();
        }

        public int MaterialId { get; set; }
        public int RawMaterialTypeId { get; set; }
        public string MaterialDescription { get; set; }
        public decimal Price { get; set; }
        public int UnitCount { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Diameter { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeRawMaterial RawMaterialType { get; set; }
        public virtual ICollection<JobMaterial> JobMaterials { get; set; }
    }
}
