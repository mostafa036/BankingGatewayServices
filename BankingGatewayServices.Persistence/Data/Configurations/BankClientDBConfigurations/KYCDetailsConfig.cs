using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingGatewayServices.Domain.Database.BankClientDB;

namespace BankingGatewayServices.Persistence.Data.Configurations.BankClientDBConfigurations
{
    public class KYCDetailsConfig : IEntityTypeConfiguration<KYCDetails>
    {
        public void Configure(EntityTypeBuilder<KYCDetails> entity)
        {

            entity.HasKey(k => k.KYCID);

            entity.Property(k => k.DocumentType)
                  .IsRequired()
                  .HasConversion<string>(); // Store enum as string

            entity.Property(k => k.DocumentNumber)
                  .IsRequired()
                  .HasMaxLength(50);

            entity.Property(k => k.IssuedDate)
                  .IsRequired();

            entity.Property(k => k.ExpiryDate)
                  .IsRequired();

            entity.Property(k => k.IssuingAuthority)
                  .HasMaxLength(100);

            entity.Property(k => k.DocumentStatus)
                  .IsRequired()
                  .HasConversion<string>(); // Store enum as string

            entity.Property(k => k.UploadPath)
                  .HasMaxLength(255);

            entity.Property(k => k.NameFile)
                  .HasMaxLength(100);

            entity.HasOne(k => k.Clientes)
                  .WithMany(c => c.KYCs) // Assuming a one-to-many relationship
                  .HasForeignKey(k => k.ClientID);
        }
    }
}
