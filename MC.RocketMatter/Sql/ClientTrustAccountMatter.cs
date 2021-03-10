using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class ClientTrustAccountMatter {
        public Guid ID { get; set; }

        [ForeignKey(nameof(ClientTrustAccount))]
        public int ClientTrustAccountId { get; set; }
        public virtual ClientTrustAccount ClientTrustAccount { get; set; }

        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public bool IsDeleted { get; set; }


    }


}
