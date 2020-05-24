using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Document {
        public int ID { get; set; }

        [ForeignKey(nameof(Activity))]
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }

        public long Size { get; set; }
        public string Title { get; set; }
        public string FileUrl { get; set; }

        [ForeignKey(nameof(DocumentType))]
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }

        public bool IsFlagged { get; set; }

        [ForeignKey(nameof(LedgerEntry))]
        public int LedgerEntryId { get; set; }
        public virtual LedgerEntry LedgerEntry { get; set; }

        public string DocumentUid { get; set; }
        public bool IsUnavailable { get; set; }

        public int? ParentDirectoryId { get; set; }

        public string FileName { get; set; }

        public int? TenantId { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessiondID { get; set; }

    }


}
