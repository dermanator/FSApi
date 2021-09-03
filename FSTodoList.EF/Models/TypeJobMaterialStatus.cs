using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeJobMaterialStatus
    {
        public TypeJobMaterialStatus()
        {
            JobMaterials = new HashSet<JobMaterial>();
        }

        public int JobMaterialStatusId { get; set; }
        public string JobMaterialStatus { get; set; }

        public virtual ICollection<JobMaterial> JobMaterials { get; set; }
    }
}
