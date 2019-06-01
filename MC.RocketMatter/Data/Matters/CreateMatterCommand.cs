using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter  {
    public class CreateMatterCommand {
        public long? PrimaryAttorneyContactID { get; set; }

        public string Description { get; set; }
        public DateTimeOffset? OpenDate { get; set; }
        public DateTimeOffset? ClosedDate { get; set; }
        public DateTimeOffset? CompletedDate { get; set; }
        public string EMailFolder { get; set; }
        public string Name { get; set; }
        public string ClientMatter { get; set; }
        public ContactIdReference Client { get; set; }
        public long? MatterStatusTypeId { get; set; }
    }

    public class ContactIdReference {
        public long ContactID { get; set; }
        public long ID { get; set; }
    }

}
