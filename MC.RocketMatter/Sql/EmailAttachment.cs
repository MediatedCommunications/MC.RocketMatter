using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class EmailAttachment {
        public int ID { get; set; }

        [ForeignKey(nameof(Email))]
        public int EmailId { get; set; }
        public virtual Email Email { get; set; }

        public string Name { get; set; }
        public decimal Size { get; set; }
        public string MimeType { get; set; }
        public bool IsDeleted { get; set; }
        public int? TenantId { get; set; }
        public string AttachmentUid { get; set; }

    }

}
