
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
    partial class ClientesConfig : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> entity)
        {

            // Primary Key
            entity.HasKey(CL => CL.Id);

            // Property Configurations

            entity.Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAdd(); ;

            entity.Property(c => c.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAddOrUpdate(); ;

            entity.Property(c => c.DisplayName).IsRequired().HasMaxLength(200);

            entity.Property(c => c.NationalID).IsRequired().HasMaxLength(50);

            // Relationships


            // Language relationship
            entity.HasOne(c => c.Language)
                  .WithMany()
                  .HasForeignKey(c => c.LanguageId)
                  .OnDelete(DeleteBehavior.Restrict);

            // Country relationship
            entity.HasOne(c => c.Country)
                  .WithMany()
                  .HasForeignKey(c => c.CountryId);


            // One-to-Many Relationships
            entity.HasMany(c => c.ClientesPreferences)
                  .WithOne()
                  .HasForeignKey(cp => cp.CientID);


            entity.HasMany(c => c.Alerts)
                  .WithOne()
                  .HasForeignKey(a => a.ClientID);



            entity.HasMany(c => c.Beneficiaries)
                  .WithOne()
                  .HasForeignKey(b => b.ClientID);



            entity.HasMany(c => c.ClientFeedbacks)
                  .WithOne()
                  .HasForeignKey(cf => cf.CientID);



            entity.HasMany(c => c.KYCs)
                  .WithOne()
                  .HasForeignKey(k => k.ClientID);



            entity.HasMany(c => c.Messages)
                  .WithOne()
                  .HasForeignKey(m => m.ClientID);



            entity.HasMany(c => c.Notifications)
                  .WithOne()
                  .HasForeignKey(n => n.CientID);



            entity.HasMany(c => c.SupportTickets)
                  .WithOne()
                  .HasForeignKey(st => st.CientID);


            // One-to-One Relationships
            entity.HasOne(c => c.Card)
                  .WithOne()
                  .HasForeignKey<Card>(card => card.ClientID);


            entity.HasOne(c => c.LoginCredential)
                  .WithOne()
                  .HasForeignKey<LoginCredential>(lc => lc.CientID);

        }
    }
}
