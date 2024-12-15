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
    public class AlertConfig : IEntityTypeConfiguration<Alert>
    {
        public void Configure(EntityTypeBuilder<Alert> builder)
        {

            // Primary key
            builder.HasKey(a => a.AlertID);

            // Property configurations
            builder.Property(a => a.Description)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(a => a.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();

            builder.Property(a => a.ResolvedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAddOrUpdate();

            builder.Property(a => a.AlertType)
                   .HasConversion<int>() // Convert enum to integer
                   .IsRequired();

            builder.Property(a => a.Status)
                   .HasConversion<int>() // Convert enum to integer
                   .IsRequired();

            // Relationships
            builder.HasOne(a => a.Clientes)
                   .WithMany()
                   .HasForeignKey(a => a.ClientID);
        }
    }

}