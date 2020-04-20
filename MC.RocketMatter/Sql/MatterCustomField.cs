using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class MatterCustomField {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Position { get; set; }

        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

        public Guid? MatterFieldId { get; set; }

    }


}
