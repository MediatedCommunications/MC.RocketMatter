using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Activity {
        public int ID { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        public DateTime DateAndTime { get; set; }
        public int TotalSeconds { get; set; }
        public decimal  BillableUnits { get; set; }
        public string Notes { get; set; }

        [ForeignKey(nameof(ActivityType))]
        public int ActivityTypeId { get; set; }
        public virtual ActivityType ActivityType { get; set; }

        public decimal Cost { get; set; }

        /// <summary>
        /// If the item is No-Charge
        /// </summary>
        public bool IsCredit { get; set; }
        public int DeletedMatterId { get; set; }
        
        [ForeignKey(nameof(Invoice))]
        public int? InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }


        public bool IsLineItemOverride { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool BillingDateOverride { get; set; }

        /// <summary>
        /// Invisible on Bill
        /// </summary>
        public bool NonBillable { get; set; }

        public int? TenantId { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsPaymentProcessingFee { get; set; }
        public bool IsSurcharge { get; set; }
        public bool IsConvenienceFee { get; set; }
        public bool SyncQboAsCheck { get; set; }
        public int? ImportSessionId { get; set; }
        public int? ImportStatusId { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

        public virtual ICollection<CalendarEntry> CalendarEntries { get; set; }
        public virtual ICollection<UserCalendarEntry> UserCalendarEntries { get; set; }
        public virtual ICollection<Email> EMails { get; set; }
        public virtual ICollection<Note> NoteItems { get; set; }
        public virtual ICollection<TodoItem> TodoItems { get; set; }
        
        public virtual ICollection<InvoicedActivityAmount> InvoicedActivityAmounts { get; set; }

    }


}
