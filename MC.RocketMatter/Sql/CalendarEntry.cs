using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class CalendarEntry {
        public int ID { get; set; }

        [ForeignKey(nameof(Activity))]
        public int ActivityID { get; set; }
        public virtual Activity Activity { get; set; }

        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime EventEndTime { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsFlagged { get; set; }
        public bool IsAllDayEvent { get; set; }
        public bool IsBillableForOwner { get; set; }

        public string PhoneNumber { get; set; }
        
        
        public DateTime ReminderDateTime { get; set; }
        public int MailItemId { get; set; }
        
        public int? ParentEventId { get; set; }
        
        public DateTime EventStartTime { get; set; }
        public int? MatterTemplateMilestoneActionId { get; set; }

        public bool IsMilestonePending { get; set; }
        public int? TenantId { get; set; }

        public string WebLink { get; set; }
        public bool IsCourtRule { get; set; }
        public Guid? MatterCourtRuleId { get; set; }

        public string ThirdPartyDeadlineId { get; set; }
        public bool? ThirdPartyDeadlineIdHasBeenUpdated { get; set; }
        public string ThirdPartyDeadlineIdUpdatedDescription { get; set; } 
        public string ThirdPartyOrganizerEmail { get; set; }

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

    }

    public class UserCalendarEntry {
        public int ID { get; set; }
        public bool IsOwner { get; set; }

        [ForeignKey(nameof(Activity))]
        public int ActivityID { get; set; }
        public virtual Activity Activity { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int InviteStatusTypeId { get; set; }
        public int BillForParticipant { get; set; }
        public int NonBillableForParticipant { get; set; }

        public int? TenantId { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

    }


}
