using System;
using System.Collections.Generic;

namespace MC.RocketMatter {
    public class ClientWrapper : DataWrapper {
        public ClientData Client { get; set; }
    }

    public class TaskWrapper<T> : DataWrapper {
        public T Task { get; set; }
    }

    public class TaskWrapper : TaskWrapper<TaskData> {

    }


    public class Milestone {
        public long Id { get; set; }
        public long TaskId { get; set; }
        public long EventId { get; set; }
        public long MatterTemplateMilestoneId { get; set; }
        public DateTimeOffset MilestoneDate { get; set; }
    }

    public class ShortContact {
        public long ID { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        
        public long ContactId { get; set; }
        public string Initials { get; set; }
    }


    public class TaskData {
        public string Title { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public long OwnerID { get; set; }
        public ShortContact Owner { get; set; }
        public long AssignedToID { get; set; }
        public ShortContact AssignTo { get; set; }
        public List<string> Tags { get; set; }
        public long Position { get; set; }
        public long MatterID { get; set; }
        public long MatterPosition { get; set; }
        public List<Milestone> Milestones { get; set; }
        public long MatterTemplateMilestoneActionId { get; set; }
        public bool IsMilestonePending { get; set; }
        public bool IsComplete { get; set; }
        public long ActivityId { get; set; }
        public bool IsRead { get; set; }
        public bool Invoiced { get; set; }
        public bool PendingInvoicing { get; set; }
        public DateTimeOffset? BillingDate { get; set; }
        public long TotalSeconds { get; set; }
        public long BillableUnits { get; set; }
        public string Notes { get; set; }
        public long Cost { get; set; }
        public bool IsNoCharge { get; set; }
        public bool IsNonBillable { get; set; }
        public DateTimeOffset? CompletedDate { get; set; }
        public bool OwnerIsRole { get; set; }
        public bool AssignedToIsRole { get; set; }
        public string OwnerRole { get; set; }
        public string AssignedToRole { get; set; }
        public long ID { get; set; }
    }

    public class TimeEntryWrapper<T> : DataWrapper {
        public T BillableTime { get; set; }
    }

    public class TimeEntryWrapper : TimeEntryWrapper<TimeEntryData> { 
    
    }


    public class TimeEntryData {
        public string Description { get; set; }
        public long MatterId { get; set; }
        public long ClientId { get; set; }
        public List<string> Tags { get; set; }
        public MatterData Matter { get; set; }
        public long UserId { get; set; }
        public ShortContact User { get; set; }
        public DateTimeOffset? BillingDate { get; set; }
        public decimal BillableUnits { get; set; }
        public decimal BillingRate { get; set; }
        public long CostOverride { get; set; }
        public bool IsLineItemOverride { get; set; }
        public bool IsNoCharge { get; set; }
        public bool NonBillable { get; set; }
        public string LEDESTaskCode { get; set; }
        public string LEDESActivityCode { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsSurchargeable { get; set; }
        public string MatterName { get; set; }
        public string UserFullName { get; set; }
        public bool IsInvoiced { get; set; }
        public bool MatterClosed { get; set; }
        public long ActivityTypeId { get; set; }
        public string ActivityCodeDescription { get; set; }
        public string TaskCodeDescription { get; set; }
        public long TotalSeconds { get; set; }
        public long ID { get; set; }
    }


}
