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
    public class NotificationConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> entity)
        {

            // Primary key
            entity.HasKey(n => n.NotificationID);

            // Title configuration
            entity.Property(n => n.Title)
                  .IsRequired()
                  .HasMaxLength(200); // Example: Max length for title

            // Message configuration
            entity.Property(n => n.Message)
                  .IsRequired()
                  .HasMaxLength(2000); // Example: Max length for message content

            // Status property configuration
            entity.Property(n => n.Status)
                  .IsRequired()
                  .HasConversion<string>(); // Store the enum as a string in the database

            // Relationship: Many notifications to one Clientes
            entity.HasOne(n => n.Clientes)
                  .WithMany(c => c.Notifications) // Add a `Notifications` collection in `Clientes`
                  .HasForeignKey(n => n.CientID);
        }
    }
}
