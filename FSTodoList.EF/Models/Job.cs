using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Job
    {
        public Job()
        {
            EmployeePerformances = new HashSet<EmployeePerformance>();
            InverseParentJob = new HashSet<Job>();
            JobDueDates = new HashSet<JobDueDate>();
            JobHardwares = new HashSet<JobHardware>();
            JobMaterials = new HashSet<JobMaterial>();
            JobRoutes = new HashSet<JobRoute>();
            TimeEntries = new HashSet<TimeEntry>();
            TimeEntryLogs = new HashSet<TimeEntryLog>();
            XrefJobCells = new HashSet<XrefJobCell>();
            XrefJobParts = new HashSet<XrefJobPart>();
            XrefJobTimeEntries = new HashSet<XrefJobTimeEntry>();
        }

        public int JobId { get; set; }
        public int OrderId { get; set; }
        public int? ParentJobId { get; set; }
        public int JobHierarchyLevel { get; set; }
        public int JobStatusTypeId { get; set; }
        public ulong Red { get; set; }
        public int? PartId { get; set; }
        public string PartNumber { get; set; }
        public string Revision { get; set; }
        public string JobNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public int? Quantity { get; set; }
        public int? JobExtra { get; set; }
        public int? JobTotal { get; set; }
        public int ProcessExtra { get; set; }
        public decimal Price { get; set; }
        public decimal ExtendedPrice { get; set; }
        public string TravelerNote { get; set; }
        public string CustomerNote { get; set; }
        public int Sequence { get; set; }
        public int? TravelerPrintedById { get; set; }
        public DateTime? TravelerPrintedDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }

        public virtual TypeJobStatus JobStatusType { get; set; }
        public virtual Order Order { get; set; }
        public virtual Job ParentJob { get; set; }
        public virtual Part Part { get; set; }
        public virtual User TravelerPrintedBy { get; set; }
        public virtual ICollection<EmployeePerformance> EmployeePerformances { get; set; }
        public virtual ICollection<Job> InverseParentJob { get; set; }
        public virtual ICollection<JobDueDate> JobDueDates { get; set; }
        public virtual ICollection<JobHardware> JobHardwares { get; set; }
        public virtual ICollection<JobMaterial> JobMaterials { get; set; }
        public virtual ICollection<JobRoute> JobRoutes { get; set; }
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
        public virtual ICollection<TimeEntryLog> TimeEntryLogs { get; set; }
        public virtual ICollection<XrefJobCell> XrefJobCells { get; set; }
        public virtual ICollection<XrefJobPart> XrefJobParts { get; set; }
        public virtual ICollection<XrefJobTimeEntry> XrefJobTimeEntries { get; set; }
    }
}
