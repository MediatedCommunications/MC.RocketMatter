using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class MatterCustomFieldDefinitionPicklistOption {
        public Guid ID { get; set; }
        
        [ForeignKey(nameof(CustomFieldDefinition))]
        public Guid MatterFieldId { get; set; }
        public virtual MatterCustomFieldDefinition CustomFieldDefinition { get; set; }

        public string Option { get; set; }
        public int Position { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TenantId { get; set; }
        public bool IsDeleted { get; set; }
    }

}
