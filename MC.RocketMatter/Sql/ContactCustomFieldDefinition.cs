using System;
using System.Collections.Generic;

namespace MC.RocketMatter.Sql {
    public class ContactCustomFieldDefinition {
        public Guid ID { get; set; }

        public string Name { get; set; }
        public int Position { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TenantId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDefault { get; set; }
        public CustomFieldDefinitionType Type { get; set; }

        public virtual ICollection<ContactCustomFieldValue> CustomFieldValues { get; set; }
        public virtual ICollection<ContactCustomFieldDefinitionPicklistOption> PicklistOptions { get; set; }

    }

}
