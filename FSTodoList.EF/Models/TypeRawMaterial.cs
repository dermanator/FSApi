using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeRawMaterial
    {
        public TypeRawMaterial()
        {
            JobMaterials = new HashSet<JobMaterial>();
            Materials = new HashSet<Material>();
            XrefPartMaterials = new HashSet<XrefPartMaterial>();
        }

        public int RawMaterialTypeId { get; set; }
        public int RawMaterialId { get; set; }
        public string RawMaterialDetail { get; set; }
        public string RawMaterialTypeDescription { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual RawMaterial RawMaterial { get; set; }
        public virtual ICollection<JobMaterial> JobMaterials { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<XrefPartMaterial> XrefPartMaterials { get; set; }
    }
}
