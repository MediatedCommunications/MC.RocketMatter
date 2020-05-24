using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class ContactCustomFieldDefinitionPicklistOption {
        public Guid ID { get; set; }

        [ForeignKey(nameof(CustomFieldDefinition))]
        public Guid ContactFieldId { get; set; }
        public virtual ContactCustomFieldDefinition CustomFieldDefinition { get; set; }

        public string Option { get; set; }
        public int Position { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TenantId { get; set; }
        public bool IsDeleted { get; set; }
    }

}
