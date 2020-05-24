using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Contact {
        public int ID { get; set; }

        public string Salutation { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Suffix { get; set; }

        public string HomeAddressLine1 { get; set; }
        public string HomeAddressLine2 { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomePostalCode { get; set; }
        public string HomeCountry { get; set; }

        public string WorkAddressLine1 { get; set; }
        public string WorkAddressLine2 { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkPostalCode { get; set; }
        public string WorkCountry { get; set; }

        public string WorkEmail { get; set; }
        public string HomeEmail { get; set; }

        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }

        public int? CompanyId { get; set; }
        public string AdditionalInfo { get; set; }

        [ForeignKey(nameof(ContactType))]
        public byte ContactTypeId { get; set; }
        public virtual ContactType ContactType { get; set; }

        public string Notes { get; set; }
        public int PreferredAddress { get; set; }
        public string CompanyName { get; set; }

        public string WorkFax { get; set; }
        public string Website { get; set; }

        public bool IsDeleted { get; set; }
        public string WorkPhoneExt { get; set; }
        public string SkypeUserName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public DateTime? CreatedDate_LocalTime { get; set; }
        public DateTime? LastModifiedDate_LocalTime { get; set; }


        public int? PrimaryContactId { get; set; }
        public string PreferredDisplayName { get; set; }
        public int? ImportSessionId { get; set; }
        public int? ImportStatusId { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }

        public virtual ICollection<ContactCustomFieldValue> CustomFields { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<MatterContact> RelatedMatters { get; set; }

        public static string DefaultAdditionalInfo => "<ContactInfo />";

    }





}
