﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefRoleFeature
    {
        public int RoleId { get; set; }
        public int FeatureId { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual Role Role { get; set; }
    }
}
