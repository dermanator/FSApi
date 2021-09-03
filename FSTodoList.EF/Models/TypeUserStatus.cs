using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeUserStatus
    {
        public int StatusId { get; set; }
        public string StatusValue { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }
    }
}
