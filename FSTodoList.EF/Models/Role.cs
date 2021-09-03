using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Role
    {
        public Role()
        {
            XrefRoleFeatures = new HashSet<XrefRoleFeature>();
            XrefUserRoles = new HashSet<XrefUserRole>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartPage { get; set; }

        public virtual ICollection<XrefRoleFeature> XrefRoleFeatures { get; set; }
        public virtual ICollection<XrefUserRole> XrefUserRoles { get; set; }
    }
}
