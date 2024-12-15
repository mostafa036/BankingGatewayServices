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
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> entity)
        {


            // Primary key
            entity.HasKey(m => m.MessageID);

            // Content property configuration
            entity.Property(m => m.Content)
                  .IsRequired()
                  .HasMaxLength(1000); // Example: Max length for message content

            // Status property configuration
            entity.Property(m => m.Status)
                  .IsRequired()
                  .HasConversion<string>(); // Store as string in the database

            // Relationship: Many messages to one Clientes
            entity.HasOne(m => m.Clientes)
                  .WithMany(c => c.Messages) // Add a `Messages` collection in `Clientes`.
                  .HasForeignKey(m => m.ClientID);
        }
    }
}
