using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter.Sql {
    public partial class RmContext : DbContext {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        
        public DbSet<Email> Emails { get; set; }
        public DbSet<EmailIntegrationType> EmailIntegrationTypes { get; set; }

        public DbSet<Note> Notes { get; set; }
        public DbSet<TodoItem> Tasks { get; set; }
        
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<ContactCustomField> ContactCustomFields { get; set; }
        

        public DbSet<User> Users { get; set; }
        public DbSet<UserRate> UserRates { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Matter> Matters { get; set; }
        public DbSet<MatterStatusType> MatterStatuses { get; set; }
        public DbSet<MatterType> MatterTypes { get; set; }
        public DbSet<MatterCustomField> MatterCustomFields { get; set; }
        public DbSet<MatterPermissionType> MatterPermissionTypes { get; set; }
        public DbSet<MatterContact> MatterContacts { get; set; }
        public DbSet<MatterTrustAccount> MatterTrustAccounts { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        


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


            modelBuilder.Entity<ContactCustomField>()
                .ToTable("ContactsCustomFields")
                ;

            modelBuilder.Entity<MatterContact>()
                .ToTable("ContactsMatters")
                ;

            modelBuilder.Entity<MatterBillingType>()
                .ToTable("MatterDefaultBillingTypes")
                ;
            
            modelBuilder.Entity<MatterCustomField>()
                .ToTable("MattersCustomFields")
                ;

            modelBuilder.Entity<Activity>()
                .ToTable("Activities")
                ;

            modelBuilder.Entity<TodoItem>()
                .ToTable("TodoItems")
                ;


        }

        public RmContext Clone() {
            return new RmContext(ConnectionString);
        }



    }


}
