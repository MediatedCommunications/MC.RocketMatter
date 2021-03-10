using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class MatterTrustLedgerEntry {
        public int ID { get; set; }

        [ForeignKey(nameof(MatterTrustAccount))]
        public int MatterTrustAccountId { get; set; }
        public virtual MatterTrustAccount MatterTrustAccount { get; set; }


        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public decimal Fees { get; set; }
        public decimal Cost { get; set; }
        public bool IsCredit { get; set; }
        public bool IsConfirmed { get; set; }
        
        [ForeignKey(nameof(ClientTrustLedgerEntry))]
        public int ClientTrustLedgerEntryId { get; set; }
        public virtual ClientTrustLedgerEntry ClientTrustLedgerEntry { get; set; }

        public DateTime ConfirmedOnDate { get; set; }
        public DateTime? UndoDate { get; set; }

        [ForeignKey(nameof(FromLedgerEntry))]
        public int FromLedgerEntryId { get; set; }
        public virtual LedgerEntry FromLedgerEntry { get; set; }

        [ForeignKey(nameof(ToLedgerEntry))]
        public int ToLedgerEntryId { get; set; }
        public virtual LedgerEntry ToLedgerEntry { get; set; }

        public bool IsAdjustment { get; set; }
        public bool? ApplyFundsToUnpaidInvoices { get; set; }

    }

}
