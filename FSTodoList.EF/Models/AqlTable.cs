using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class AqlTable
    {
        public int Id { get; set; }
        public int? LotSizeLower { get; set; }
        public int? LotSizeUpper { get; set; }
        public decimal? Aqlvalue { get; set; }
        public int? SampleSize { get; set; }
    }
}
