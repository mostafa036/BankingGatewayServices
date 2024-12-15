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
    public class LoginCredentialConfig : IEntityTypeConfiguration<LoginCredential>
    {
        public void Configure(EntityTypeBuilder<LoginCredential> entity)
        {

            // Primary key
            entity.HasKey(lc => lc.CredentialID);

            // Required properties
            entity.Property(lc => lc.SecurityQuestion)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(lc => lc.SecurityAnswer)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(lc => lc.RecoveryEmail)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(lc => lc.RecoveryPhone)
                  .IsRequired()
                  .HasMaxLength(15);

            // Relationship: One-to-one with Clientes
            entity.HasOne(lc => lc.Clientes)
                  .WithOne(c => c.LoginCredential) // Add a `LoginCredential` navigation property in `Clientes`.
                  .HasForeignKey<LoginCredential>(lc => lc.CientID);
        }
    }
}
