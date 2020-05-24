using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {

    public class TodoItem {
        public int ID { get; set; }

        [ForeignKey(nameof(Activity))]
        public int ActivityID { get; set; }
        public virtual Activity Activity { get; set; }


        public TodoItemState State { get; set; }
        public int TodoListId { get; set; }
        public int Position { get; set; }
        public string AdditionalNotes { get; set; }
        public int MatterPosition { get; set; }
        public int AssignedToUserId { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsRead { get; set; }
        public DateTime CompletedDate { get; set; }
        public int? MatterTemplateMilestoneActionId { get; set; }
        public bool IsMilestonePending { get; set; }
        public int? TenantId { get; set; }

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }
    }

    public enum TodoItemState {
        NotStarted = 0,
        Complete = 1,

    }

    public static class DatabaseHelpers {
        public static DateTime MinDate { get; private set; } = new DateTime(1776, 07, 04);
    }


}
