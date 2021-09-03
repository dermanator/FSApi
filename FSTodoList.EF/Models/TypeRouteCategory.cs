using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeRouteCategory
    {
        public TypeRouteCategory()
        {
            Routes = new HashSet<Route>();
        }

        public int RouteCategoryId { get; set; }
        public int RouteTypeId { get; set; }
        public string RouteCategoryName { get; set; }
        public string RouteCategoryDescription { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
    }
}
