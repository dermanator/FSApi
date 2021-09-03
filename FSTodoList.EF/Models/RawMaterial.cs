using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class RawMaterial
    {
        public RawMaterial()
        {
            TypeRawMaterials = new HashSet<TypeRawMaterial>();
        }

        public int RawMaterialId { get; set; }
        public string RawMaterialName { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<TypeRawMaterial> TypeRawMaterials { get; set; }
    }
}
