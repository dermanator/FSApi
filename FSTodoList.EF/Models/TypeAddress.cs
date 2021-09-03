using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeAddress
    {
        public TypeAddress()
        {
            Addresses = new HashSet<Address>();
        }

        public int AddressTypeId { get; set; }
        public string Value { get; set; }
        public string DisplayValue { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
