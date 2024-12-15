using BankingGatewayServices.Domain.Database.BankClientDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Persistence.Data.Configurations.BankClientDBConfigurations
{
    public class ClientesPreferencesConfig : IEntityTypeConfiguration<ClientesPreferences>
    {
        public void Configure(EntityTypeBuilder<ClientesPreferences> entity)
        {


            // Primary Key
            entity.HasKey(cp => cp.PreferenceID);

            // Property Configurations
            entity.Property(cp => cp.ReceiveEmails)
                  .IsRequired()
                  .HasDefaultValue(true);

            entity.Property(cp => cp.ReceiveSMS)
                  .IsRequired()
                  .HasDefaultValue(true);

            entity.Property(cp => cp.ReceivePromotionalEmails)
                  .IsRequired()
                  .HasDefaultValue(false);

            entity.Property(cp => cp.ReceivePromotionalSMS)
                  .IsRequired()
                  .HasDefaultValue(false);

            entity.Property(cp => cp.PreferredContactMethod)
                  .HasConversion<string>() // Store enum as string for readability
                  .IsRequired();

            entity.Property(cp => cp.NotificationFrequency)
                  .HasConversion<string>() // Store enum as string for readability
                  .IsRequired();

            entity.Property(cp => cp.CreatedDate)
                  .IsRequired()
                  .HasDefaultValueSql("GETUTCDATE()");

            entity.Property(cp => cp.LastModifiedDate)
                  .IsRequired()
                  .HasDefaultValueSql("GETUTCDATE()");

            // Relationship Configurations
            entity.HasOne(cp => cp.Clientes)
                  .WithMany(c => c.ClientesPreferences) // One-to-Many relationship
                  .HasForeignKey(cp => cp.CientID);
        }
    }
}
