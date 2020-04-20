using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter  {

    public class CreateTaskCommand {
        public string Title { get; set; }
        public string Notes { get; set; }
        public long MatterID { get; set; }
        public bool IsNoCharge { get; set; }
        public bool IsNonBillable { get; set; }
        public DateTimeOffset? BillingDate { get; set; }
        public DateTimeOffset? CompletedDate { get; set; }
        public decimal BillableUnits { get; set; }
        public IdReferenceJson<ContactData> AssignedTo { get; set; }
        public long? AssignedToID { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public bool IsComplete { get; set; }
        
    }

    public class CreateMatterCommand {
        public long? ID { get; set; }

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

        public List<RelatedContactCommand> RelatedContacts { get; private set; } = new List<RelatedContactCommand>();
        public List<CustomFieldCommand> CustomFields { get; private set; } = new List<CustomFieldCommand>();
    }

    public class ContactIdReference {
        public long ContactID { get; set; }
        public long ID { get; set; }
    }

    public class RelatedContactCommand {
        public long ContactId { get; set; }
        public long Position { get; set; }
        public long? MatterID { get; set; }
        public string Role { get; set; }
    }

    public class CustomFieldCommand {
        public string Name { get; set; }
        public string Value { get; set; }
        public long Position { get; set; }
        public long? MatterID { get; set; }

    }


}
