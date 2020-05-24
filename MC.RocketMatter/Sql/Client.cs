using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Client {
        public int ID { get; set; }
        public string ClientCode { get; set; }

        [ForeignKey(nameof(Contact))]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        public string Currency { get; set; }
        public int? TenantId { get; set; }
        
        public int? ImportSessionId { get; set; }
        public int? ImportStatusId { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }
        public decimal? TrustBalance { get; set; }

        public virtual ICollection<ClientTrustAccount> TrustAccounts { get; set; }

    }





}
