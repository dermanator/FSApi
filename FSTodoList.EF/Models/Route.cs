using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Route
    {
        public Route()
        {
            JobRoutes = new HashSet<JobRoute>();
            PartRoutes = new HashSet<PartRoute>();
        }

        public int RouteId { get; set; }
        public int RouteTypeId { get; set; }
        public int RouteCategoryId { get; set; }
        public string RouteName { get; set; }
        public string Description { get; set; }
        public decimal? SetupTime { get; set; }
        public decimal? CycleTime { get; set; }
        public decimal? LeadTime { get; set; }
        public decimal? OutsourceTime { get; set; }
        public decimal? OutsourceUnitCost { get; set; }
        public int? UnitCount { get; set; }
        public string OperationalNotes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeRouteCategory RouteCategory { get; set; }
        public virtual TypeRoute RouteType { get; set; }
        public virtual ICollection<JobRoute> JobRoutes { get; set; }
        public virtual ICollection<PartRoute> PartRoutes { get; set; }
    }
}
