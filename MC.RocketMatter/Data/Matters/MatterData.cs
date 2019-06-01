using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {
    public class MatterData {
        public IdReferenceJson<ClientData> Client { get; set; }
        public long ID { get; set; }
        public string ClientMatter { get; set; }
        public string Name { get; set; }
        public string CurrencySymbol { get; set; }

        public long MatterTypeId { get; set; }
        public long MatterStatusTypeId { get; set; }
        public long? TaxRateId { get; set; }
        public long? DiscountRateId { get; set; }
        public long? InterestRateId { get; set; }
        public long? SurchageRateId { get; set; }
        public long? DefaultBillingTypeId {get; set;}
    }


    public class IdReferenceJson {
        public long ID { get; set; }
    }

    public class IdReferenceJson<T> : IdReferenceJson {

    }

}
