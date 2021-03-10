using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class ClientTrustAccount {
        public int ID { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsClosed { get; set; }
        public bool IsEverGreenEnabled { get; set; }
        public decimal EverGreenRetainerAmount { get; set; }
        public decimal EverGreenNotifyClientWhenAmountBelow { get; set; }
        public bool IsEverGreenAutoReplenish { get; set; }

        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

        public virtual ICollection<ClientTrustLedgerEntry> LedgerEntries { get; set; }
        public virtual ICollection<ClientTrustAccountMatter> ClientTrustAccountMatters { get; set; }

    }

}
