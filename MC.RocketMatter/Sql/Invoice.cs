using System;

namespace MC.RocketMatter.Sql {
    public class Invoice {
        public int ID { get; set; }
        public int MatterId { get; set; }
        public DateTime Date { get; set; }
        public int BatchId { get; set; }
        public int InvoiceTemplateId { get; set; }
        public decimal TaxAmount { get; set; }
        public int? TenantId { get; set; }
        public Guid? SurchargeRateHistoryId { get; set; }
        public decimal SurchargeAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Date_LocalTime { get; set; }
        public DateTime FromDate_LocalTime { get; set; }
        public DateTime ToDate_LocalTime { get; set; }

        public static int None => 0;

    }


}
