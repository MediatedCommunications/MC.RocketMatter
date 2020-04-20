using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class MatterContact {
        public int ID { get; set; }
        public int Position { get; set; }

        [ForeignKey(nameof(Contact))]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        public string ContactName { get; set; }
        public string Role { get; set; }


        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

    }


}
