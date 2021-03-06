﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class ContactCustomFieldValue {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Position { get; set; }

        [ForeignKey(nameof(Contact))]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

        [ForeignKey(nameof(CustomFieldDefinition))]
        public Guid? ContactFieldId { get; set; }
        public virtual ContactCustomFieldDefinition CustomFieldDefinition { get; set; }
    }

}
