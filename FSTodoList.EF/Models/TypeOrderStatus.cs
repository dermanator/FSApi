using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeOrderStatus
    {
        public TypeOrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int OrderStatusTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
