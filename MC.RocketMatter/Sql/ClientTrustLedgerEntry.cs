using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class ClientTrustLedgerEntry {
        public int ID { get; set; }

        [ForeignKey(nameof(ClientTrustAccount))]
        public int ClientTrustAccountId { get; set; }
        public virtual ClientTrustAccount ClientTrustAccount { get; set; }

        public int BatchId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public bool IsCredit { get; set; }
        public decimal Balance { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime? ConfirmedOnDate { get; set; }
        public DateTime? UndoDate { get; set; }
        public bool IsAdjustment { get; set; }
        public string CheckNumber { get; set; }
        public int TrustTransferReferenceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? MatterID { get; set; }
        public string ExternalTransactionId { get; set; }
        public DateTime? RefundedDate { get; set; }
        public bool? SyncQBOAsCheck { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

    }


}
