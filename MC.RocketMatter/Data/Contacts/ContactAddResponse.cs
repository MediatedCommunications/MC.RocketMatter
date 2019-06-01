using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {
    public class ContactAddResponse {
        public string WorkPhone { get; set; }
        public string Salutation { get; set; }
        public string Title { get; set; }
        public string Suffix { get; set; }
        public string MobilePhone { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Notes { get; set; }
        public string WorkFax { get; set; }
        public string WorkPhoneExt { get; set; }
        public string SkypeUserName { get; set; }
        public string PrimaryContact { get; set; }
        public int? PrimaryContactId { get; set; }
        public string PreferredDisplayName { get; set; }
        public int? ContactTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsClient { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public bool IsCompany { get; set; }
        public string WorkEmail { get; set; }
        public string WorkAddressLine1 { get; set; }
        public string WorkAddressLine2 { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkPostalCode { get; set; }
        public string WorkCountry { get; set; }
        public int? ClientID { get; set; }
        public string HomeEmail { get; set; }
        public string HomePhone { get; set; }
        public string HomeAddressLine1 { get; set; }
        public string HomeAddressLine2 { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomePostalCode { get; set; }
        public string HomeCountry { get; set; }
        public string ExternalID2 { get; set; }
        public string Initials { get; set; }
        public int? UserId { get; set; }
        public int? ID { get; set; }
    }
}
