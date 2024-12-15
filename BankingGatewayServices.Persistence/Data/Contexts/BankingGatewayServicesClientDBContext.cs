using BankingGatewayServices.Domain.Database.BankClientDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BankingGatewayServices.Persistence.Data.Contexts
{
    public class BankingGatewayServicesClientDBContext : IdentityDbContext<Clientes>
    {
        public BankingGatewayServicesClientDBContext()
        {

        }
        public BankingGatewayServicesClientDBContext(DbContextOptions<BankingGatewayServicesClientDBContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<ClientesPreferences> ClientesPreferences { get; set; }
        public DbSet<ClientFeedback> ClientFeedbacks { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<KYCDetails> KYCDetails { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LoginCredential> LoginCredentials { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }

            builder.ApplyConfigurationsFromAssembly(typeof(BankingGatewayServicesClientDBContext).Assembly);
        }


    }
}
