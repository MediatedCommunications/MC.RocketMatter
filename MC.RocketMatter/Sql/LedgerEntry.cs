using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class LedgerEntry {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }



        public decimal Amount { get; set; }

        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        public bool IsCredit { get; set; }
        public bool IsAdjustment { get; set; }
        public bool IsPaid { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice {get; set;}
        
        public decimal Cost { get; set; }
        public decimal Fees { get; set; }
        public decimal CostBalance { get; set; }
        public decimal FeesBalance { get; set; }
        public decimal Balance { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public DateTime? RefundedDate { get; set; }
        public int? TenantId { get; set; }
    }


}
