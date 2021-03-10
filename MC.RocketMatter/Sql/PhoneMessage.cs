using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class PhoneMessage {
        public int ID { get; set; }
        
        [ForeignKey(nameof(Activity))]
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }

        public string Subject { get; set; }

        [ForeignKey(nameof(Caller))]
        public int CallerId { get; set; }
        public virtual Contact Caller { get; set; }

        public string CallerName { get; set; }
        public string CallerPhoneNumber { get; set; }

        public bool IsArchived { get; set; }
        public int? TenantId { get; set; }

        [ForeignKey(nameof(Document))]
        public int? DocumentId { get; set; }
        public virtual Document Document { get; set; }

    }


}
