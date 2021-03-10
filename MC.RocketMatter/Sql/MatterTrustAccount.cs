using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter.Sql {
    public class MatterTrustAccount {
        public int ID { get; set; }
        
        [ForeignKey(nameof(Matter))]
        public int MatterId { get; set; }
        public virtual Matter Matter { get; set; }

        public virtual ICollection<MatterTrustLedgerEntry> LedgerEntries { get; set; }

    }

}
