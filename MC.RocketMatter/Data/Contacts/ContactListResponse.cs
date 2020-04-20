using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {

    [DebuggerDisplay(Debugger2.DISPLAY)]
    public class ContactListResponse {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public bool IsCompany { get; set; }
        public string CurrencySymbol { get; set; }
        public string WorkEmail { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneExt { get; set; }
        public string WorkFax { get; set; }
        public string WorkAddressLine1 { get; set; }
        public string WorkAddressLine2 { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkPostalCode { get; set; }
        public string WorkCountry { get; set; }
        public long? ClientID { get; set; }
        public string HomeEmail { get; set; }
        public string HomePhone { get; set; }
        public string HomeAddressLine1 { get; set; }
        public string HomeAddressLine2 { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomePostalCode { get; set; }
        public string HomeCountry { get; set; }
        public string ExternalID2 { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public long? ContactTypeId { get; set; }
        public long? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Initials { get; set; }
        public string Notes { get; set; }
        public long? UserId { get; set; }
        public long ID { get; set; }
        public string ExternalID { get; set; }

        protected string DebuggerDisplay {
            get {
                return $@"[{ID}] {FullName}";
            }
        }
    }
}
