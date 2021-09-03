using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeAllowableJobPartStatus
    {
        public int JobPartStatusId { get; set; }
        public int AllowableJobPartStatusId { get; set; }

        public virtual TypeJobPartStatus JobPartStatus { get; set; }
    }
}
