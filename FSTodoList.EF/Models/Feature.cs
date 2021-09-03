using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Feature
    {
        public Feature()
        {
            XrefRoleFeatures = new HashSet<XrefRoleFeature>();
        }

        public int FeatureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<XrefRoleFeature> XrefRoleFeatures { get; set; }
    }
}
