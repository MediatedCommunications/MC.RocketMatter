using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Email {
        public int ID { get; set; }

        [ForeignKey(nameof(Activity))]
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }

        public string EmailUid { get; set; }

        public string FromDisplayName { get; set; }
        public string FromAddress { get; set; }

        public string ToDisplayName { get; set; }
        public string BccDisplayName { get; set; }
        public string CcDisplayName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public DateTime DateReceived { get; set; }
        public bool HasAttachments { get; set; }

        [ForeignKey(nameof(EmailIntegrationPreferenceUser))]
        public int EmailIntegrationPreferenceUserId { get; set; }
        public virtual User EmailIntegrationPreferenceUser { get; set; }

        [ForeignKey(nameof(EmailIntegrationType))]
        public int EmailIntegrationTypeId { get; set; }
        public virtual EmailIntegrationType EmailIntegrationType { get; set; }

        public int? TenantId { get; set; }

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

        public virtual ICollection<EmailAttachment> Attachments { get; set; }
    }

    public class EmailIntegrationType {
        public int ID { get; set; }
        public string Name { get; set; }

        public static int IMAP => 1;
        public static int Outlook => 2;


    }

}
