﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeMaterial
    {
        public int MaterialTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }
    }
}
