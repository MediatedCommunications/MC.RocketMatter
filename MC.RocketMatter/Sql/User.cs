using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter.Sql {
    public class User {
        public int ID { get; set; }

        [ForeignKey(nameof(Contact))]
        public int ContactID { get; set; }
        public virtual Contact Contact { get; set; }

        public int EmploymentStatus { get; set; }

        public string UserName { get; set; }
        public string HashedPassword { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Color { get; set; }
        public string TimeZone { get; set; }
        public string Role { get; set; }
        public bool IsDeleted { get; set; }
        public int Permissions { get; set; }
        public bool IsInactive { get; set; }
        public string iCalGuid { get; set; }
        public byte[] UserAvatarBytes { get; set; }
        public string UserAvatarMimeType { get; set; }
        public Guid? MembershipId { get; set; }
        public int? TenantId { get; set; }
        public bool IsOutlookCalendarSyncEnabled { get; set; }
        public string ProfileImage { get; set; }
        /// <summary>
        /// Yes - This is supposed to be mis-spelled
        /// </summary>
        public string ProfileImageConntentType { get; set; }

        public int? ImportSessionId { get; set; }
        public int? ImportStatusId { get; set; }
        public Guid? UserFirmRoleId { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }


        public virtual ICollection<UserRate> Rates { get; set; }


        public static string DefaultColor => "#993333";
        public static string DefaultRole => "assistant";
        public static int DefaultPermissions => 1;
        public static int DefaultEmploymentStatus => 1;

        public static int NullUserId => 0;

    }

    public class UserRate {
        public int ID { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public decimal Rate { get; set; }
        public DateTime EffectiveDate { get; set; }

        public int? TenantId { get; set; }
        
        public string Import_ExternalId {get; set;}
        public Guid? Import_CreatedFromSessionID { get; set; }



    }

}
