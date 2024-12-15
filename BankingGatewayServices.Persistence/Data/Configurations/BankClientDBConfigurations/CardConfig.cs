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
    public class CardConfig : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> entity)
        {

            // Primary Key
            entity.HasKey(c => c.CardID);

            // Property Configurations
            entity.Property(c => c.CardNumber)
                  .IsRequired()
                  .HasMaxLength(16);

            entity.Property(c => c.CardType)
                  .HasConversion<string>() // Store enum as string for readability
                  .IsRequired();

            entity.Property(c => c.ExpiryDate)
                  .IsRequired();

            entity.Property(c => c.CardHolderName)
                  .IsRequired()
                  .HasMaxLength(100); // Name length constraint

            entity.Property(c => c.SecurityCode)
                  .IsRequired()
                  .HasMaxLength(4); // CVV typically 3-4 digits

            entity.Property(c => c.IssuingBank)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(c => c.BillingAddress)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(c => c.IsActive)
                  .HasDefaultValue(true);

            // Relationship Configurations
            entity.HasOne(c => c.Clientes)
                  .WithOne(cl => cl.Card) // One-to-One relationship
                  .HasForeignKey<Card>(c => c.ClientID);
        }
    }
}
