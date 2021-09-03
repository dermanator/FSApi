using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class User
    {
        public User()
        {
            EmployeePerformances = new HashSet<EmployeePerformance>();
            JobDueDateCreatedBies = new HashSet<JobDueDate>();
            JobDueDateUpdatedBies = new HashSet<JobDueDate>();
            Jobs = new HashSet<Job>();
            Quotes = new HashSet<Quote>();
            TimeEntries = new HashSet<TimeEntry>();
            TimeEntryLogs = new HashSet<TimeEntryLog>();
            Timesheets = new HashSet<Timesheet>();
            XrefJobPartStatusChangeHistoryNewSubmittedBies = new HashSet<XrefJobPartStatusChangeHistory>();
            XrefJobPartStatusChangeHistoryOldSubmittedBies = new HashSet<XrefJobPartStatusChangeHistory>();
            XrefJobParts = new HashSet<XrefJobPart>();
            XrefPurchaseOrderItemBinCreatedBies = new HashSet<XrefPurchaseOrderItemBin>();
            XrefPurchaseOrderItemBinUpdatedBies = new HashSet<XrefPurchaseOrderItemBin>();
            XrefUserRoles = new HashSet<XrefUserRole>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeNumber { get; set; }
        public int IsHourly { get; set; }
        public ulong? IsFullTimeEmployee { get; set; }
        public int? VacationHours { get; set; }
        public int ShiftId { get; set; }
        public int ScheduleId { get; set; }
        public int StatusId { get; set; }
        public int? CellId { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Cell Cell { get; set; }
        public virtual TypeUserShift Shift { get; set; }
        public virtual ICollection<EmployeePerformance> EmployeePerformances { get; set; }
        public virtual ICollection<JobDueDate> JobDueDateCreatedBies { get; set; }
        public virtual ICollection<JobDueDate> JobDueDateUpdatedBies { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
        public virtual ICollection<TimeEntryLog> TimeEntryLogs { get; set; }
        public virtual ICollection<Timesheet> Timesheets { get; set; }
        public virtual ICollection<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistoryNewSubmittedBies { get; set; }
        public virtual ICollection<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistoryOldSubmittedBies { get; set; }
        public virtual ICollection<XrefJobPart> XrefJobParts { get; set; }
        public virtual ICollection<XrefPurchaseOrderItemBin> XrefPurchaseOrderItemBinCreatedBies { get; set; }
        public virtual ICollection<XrefPurchaseOrderItemBin> XrefPurchaseOrderItemBinUpdatedBies { get; set; }
        public virtual ICollection<XrefUserRole> XrefUserRoles { get; set; }
    }
}
