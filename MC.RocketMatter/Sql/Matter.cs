using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class Matter {
        public int ID { get; set; }
        public string MatterName { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public string Description { get; set; }
        public string MatterCode { get; set; }

        [ForeignKey(nameof(MatterStatus))]
        public int MatterStatusTypeId { get; set; }
        public virtual MatterStatusType MatterStatus { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsContingency { get; set; }

        [ForeignKey(nameof(MatterType))]
        public int MatterTypeId { get; set; }
        public virtual MatterType MatterType { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? EverGreenEnabled { get; set; }
        public decimal? EverGreenRetainerAmount { get; set; }
        public decimal? EverGreenNotifyClientWhenAmountBelow { get; set; }

        [ForeignKey(nameof(PrimaryAttorney))]
        public int PrimaryAttorneyContactId { get; set; }
        public virtual Contact PrimaryAttorney { get; set; }

        [ForeignKey(nameof(Permissions))]
        public int? MatterPermissionTypeID { get; set; }
        public virtual MatterPermissionType Permissions { get; set; }

        public int? TenantId { get; set; }
        public bool? IsSystemMatter { get; set; }
        public bool? EnablePaymentProcessingFee { get; set; }
        public decimal PaymentProcessingFeePercent { get; set; }
        public Guid? SurchargeRateId { get; set; }

        public int? ImportSessionId { get; set; }
        public int? ImportStatusId { get; set; }

        public decimal Budget { get; set; }

        [ForeignKey(nameof(DefaultBillingType))]
        public int? DefaultBillingTypeId { get; set; }
        public virtual MatterBillingType DefaultBillingType {get; set;}

        [ForeignKey(nameof(CurrentMatterWorkFlowStatusHistory))]
        public Guid? CurrentMatterWorkFlowStatusHistoryId { get; set; }
        public virtual WorkflowStatusHistory CurrentMatterWorkFlowStatusHistory { get; set; }

        public bool FireTemplateSelection { get; set; }
        public string Import_ExternalId { get; set; }
        public Guid? Import_CreatedFromSessionID { get; set; }
        public decimal? PendingInvoicing { get; set; }
        public decimal? CurrentBalance { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public decimal? PendingTaxes { get; set; }


        public virtual ICollection<MatterCustomFieldValue> CustomFields { get; set; }
        public virtual ICollection<MatterContact> RelatedContacts { get; set; }
        public virtual ICollection<MatterTrustAccount> TrustAccounts { get; set; }

    }

}
