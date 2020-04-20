using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Note {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int IsFlagged { get; set; }
        public DateTime DateLastModified { get; set; }
        public int TenantId { get; set; }

        [ForeignKey(nameof(Activity))]
        public int ActivityId { get; set; }
        public virtual Activity Activity{ get; set;}

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }
        



    }


}
