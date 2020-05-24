using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Invoice {
        public int ID { get; set; }

        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        public DateTime Date { get; set; }
        public int BatchId { get; set; }
        public int InvoiceTemplateId { get; set; }
        public decimal TaxAmount { get; set; }
        public int? TenantId { get; set; }
        public Guid? SurchargeRateHistoryId { get; set; }
        public decimal SurchargeAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Date_LocalTime { get; set; }
        public DateTime? FromDate_LocalTime { get; set; }
        public DateTime? ToDate_LocalTime { get; set; }

        public static int None => 0;

        public virtual ICollection<InvoicedActivityAmount> InvoicedActivities { get; set; }

    }

    public class InvoicedActivityAmount {
        public Guid ID { get; set; }

        [ForeignKey(nameof(Activity))]
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }

        public decimal Rate { get; set; }
        public decimal Amount { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public int TenantId { get; set; }
        
        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

        public DateTime? DateCreated_LocalTime { get; set; }
        public DateTime? DateModified_LocalTime { get; set; }

    }


    public class InvoicePayment {
        public int ID { get; set; }

        [ForeignKey(nameof(Debit))]        
        public int DebitId { get; set; }
        public virtual LedgerEntry Debit { get; set; }

        [ForeignKey(nameof(Credit))]
        public int CreditId { get; set; }
        public virtual LedgerEntry Credit { get; set; }

        public decimal AmountDue { get; set; }
        public decimal AmountPaid { get; set; }
    }


}
