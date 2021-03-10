using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter.Sql {

    public partial class RmContext : DbContext {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        
        public DbSet<Email> Emails { get; set; }
        public DbSet<EmailAttachment> EmailAttachments { get; set; }
        public DbSet<EmailIntegrationType> EmailIntegrationTypes { get; set; }

        public DbSet<Note> Notes { get; set; }
        public DbSet<TodoItem> Tasks { get; set; }
        
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        

        public DbSet<User> Users { get; set; }
        public DbSet<UserRate> UserRates { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientTrustAccount> ClientTrustAccounts { get; set; }
        public DbSet<ClientTrustLedgerEntry> ClientTrustLedgerEntries { get; set; }
        public DbSet<ClientTrustAccountMatter> ClientTrustAccountMatters { get; set; }

        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentIntegration> DocumentIntegrations { get; set; }

        public DbSet<Matter> Matters { get; set; }
        public DbSet<MatterTrustAccount> MatterTrustAccounts { get; set; }
        public DbSet<MatterTrustLedgerEntry> MatterTrustLedgerEntries { get; set; }

        public DbSet<MatterStatusType> MatterStatuses { get; set; }
        public DbSet<MatterType> MatterTypes { get; set; }

        public DbSet<MatterPermissionType> MatterPermissionTypes { get; set; }
        public DbSet<MatterContact> MatterContacts { get; set; }

        public DbSet<MatterCustomFieldDefinition> MatterCustomFieldDefinitions { get; set; }
        public DbSet<MatterCustomFieldDefinitionPicklistOption> MatterCustomFieldDefinitionPicklistOptions { get; set; }
        public DbSet<MatterCustomFieldValue> MatterCustomFields { get; set; }

        public DbSet<ContactCustomFieldDefinition> ContactCustomFieldDefinitions { get; set; }
        public DbSet<ContactCustomFieldDefinitionPicklistOption> ContactCustomFieldDefinitionPicklistOptions { get; set; }
        public DbSet<ContactCustomFieldValue> ContactCustomFields { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoicedActivityAmount> InvoicedActivityAmounts { get; set; }

        public DbSet<InvoicePayment> InvoicePayments { get; set; }
        public DbSet<LedgerEntry> LedgerEntries { get; set; }
        
        public DbSet<WorkflowPracticeArea> WorkflowPracticeAreas { get; set; }
        public DbSet<WorkflowStatus> WorkflowStatus { get; set; }
        public DbSet<WorkflowStatusHistory> WorkflowHistory { get; set; }

        public DbSet<PhoneMessage> PhoneMessages { get; set; }

        public DbSet<SystemProp> SystemProps { get; set; }

        public string ConnectionString { get; private set; }

        public RmContext(string ConnectionString) {
            this.ConnectionString = ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseLazyLoadingProxies()
                ;

            optionsBuilder.UseSqlServer(ConnectionString, x => x.EnableRetryOnFailure());

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<CalendarEntry>()
                .ToTable("CalendarEntries")
                ;

            modelBuilder.Entity<UserCalendarEntry>()
                .ToTable("CalendarEntriesUsers")
                ;


            modelBuilder.Entity<MatterContact>()
                .ToTable("ContactsMatters")
                ;

            modelBuilder.Entity<MatterBillingType>()
                .ToTable("MatterDefaultBillingTypes")
                ;
            
            modelBuilder.Entity<Activity>()
                .ToTable("Activities")
                ;

            modelBuilder.Entity<TodoItem>()
                .ToTable("TodoItems")
                ;


            modelBuilder.Entity<WorkflowPracticeArea>()
    .           ToTable("WorkflowPracticeArea")
                ;


            modelBuilder.Entity<WorkflowStatus>()
                .ToTable("MatterWorkFlowStatus")
                ;

            modelBuilder.Entity<DocumentIntegration>()
                .ToTable("DocumentIntegration")
                ;

            modelBuilder.Entity<WorkflowStatusHistory>()
                .ToTable("MatterWorkFlowStatusHistory")
                ;

            modelBuilder.Entity<MatterCustomFieldDefinition>()
                .ToTable("MatterFields")
                .Property(x => x.Type)
                .HasConversion(new EnumToStringConverter<CustomFieldDefinitionType>())
                ;

            modelBuilder.Entity<MatterCustomFieldDefinitionPicklistOption>()
                .ToTable("MatterFieldSelectOptions")
                ;

            modelBuilder.Entity<MatterCustomFieldValue>()
                .ToTable("MattersCustomFields")
                ;



            modelBuilder.Entity<ContactCustomFieldDefinition>()
                .ToTable("ContactFields")
                .Property(x => x.Type)
                .HasConversion(new EnumToStringConverter<CustomFieldDefinitionType>())
                ;

            modelBuilder.Entity<ContactCustomFieldDefinitionPicklistOption>()
                .ToTable("ContactFieldSelectOptions")
                ;

            modelBuilder.Entity<ContactCustomFieldValue>()
                .ToTable("ContactsCustomFields")
                ;


            modelBuilder.Entity<InvoicePayment>()
                .ToTable("PaymentsInvoices")
                ;

            modelBuilder.Entity<LedgerEntry>()
                .ToTable("LedgerEntries")
                ;


        }

        public RmContext Clone() {
            return new RmContext(ConnectionString);
        }



    }


}
