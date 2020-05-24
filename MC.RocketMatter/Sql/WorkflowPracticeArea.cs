using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class WorkflowPracticeArea {
        public Guid Id { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        
        public int TenantId { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        
        
    }


    public class WorkflowStatusHistory {
        public Guid Id { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TenantId { get; set; }
        public bool IsDeleted { get; set; }
        
        
        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        [ForeignKey(nameof(PreviousHistory))]
        public Guid? PreviousHistoryId { get; set; }
        public virtual WorkflowStatusHistory PreviousHistory { get; set; }

        [ForeignKey(nameof(Status))]
        public Guid StatusId { get; set; }
        public virtual WorkflowStatus Status { get; set; }

        [ForeignKey(nameof(ModifiedByUser))]
        public int? ModifiedByUserId { get; set; }
        public virtual User ModifiedByUser { get; set; }

        [ForeignKey(nameof(PracticeArea))]
        public Guid PracticeAreaId { get; set; }
        public virtual WorkflowPracticeArea PracticeArea { get; set; }

        public DateTime? DateCreated_LocalTime { get; set; }
        public DateTime? DateModified_LocalTime { get; set; }

    }

    public class WorkflowStatus {
        public Guid ID { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TenantId { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public int MinDays { get; set; }
        public int MaxDays { get; set; }
    }



}
