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
    public class SupportTicketConfig : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> entity)
        {

            // Primary key
            entity.HasKey(st => st.TicketID);

            // Subject configuration
            entity.Property(st => st.Subject)
                  .IsRequired()
                  .HasMaxLength(100); // Example: Max length for the subject

            // Description configuration
            entity.Property(st => st.Description)
                  .IsRequired()
                  .HasMaxLength(2000); // Example: Max length for the description

            // Status property configuration
            entity.Property(st => st.Status)
                  .IsRequired()
                  .HasConversion<string>(); // Store enum as a string

            // CreatedAt and UpdatedAt configuration
            entity.Property(st => st.CreatedAt)
                  .HasDefaultValueSql("GETDATE()")
                  .IsRequired();

            entity.Property(st => st.UpdatedAt)
                  .IsRequired(false);

            // Relationship: Many tickets to one Clientes
            entity.HasOne(st => st.Clientes)
                  .WithMany(c => c.SupportTickets) // Add `SupportTickets` to `Clientes`
                  .HasForeignKey(st => st.CientID);
        }
    }
}
