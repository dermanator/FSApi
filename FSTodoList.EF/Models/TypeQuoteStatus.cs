using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeQuoteStatus
    {
        public TypeQuoteStatus()
        {
            Quotes = new HashSet<Quote>();
        }

        public int QuoteStatusId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
