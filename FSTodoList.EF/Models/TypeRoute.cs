using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeRoute
    {
        public TypeRoute()
        {
            JobRoutes = new HashSet<JobRoute>();
            PartRoutes = new HashSet<PartRoute>();
            Routes = new HashSet<Route>();
        }

        public int RouteTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<JobRoute> JobRoutes { get; set; }
        public virtual ICollection<PartRoute> PartRoutes { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
    }
}
