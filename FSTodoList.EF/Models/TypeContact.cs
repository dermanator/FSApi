using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeContact
    {
        public TypeContact()
        {
            Contacts = new HashSet<Contact>();
        }

        public int ContactTypeId { get; set; }
        public string Value { get; set; }
        public string DisplayValue { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
