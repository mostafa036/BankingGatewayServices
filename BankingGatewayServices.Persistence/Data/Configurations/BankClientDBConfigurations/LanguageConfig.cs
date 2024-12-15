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
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> entity)
        {


            entity.HasKey(l => l.LanguageId);

            entity.Property(l => l.LanguageName)
                  .IsRequired()
                  .HasMaxLength(100);

            // One-to-many relationship with Clientes
            entity.HasMany(l => l.Clientes)
                  .WithOne(c => c.Language)
                  .HasForeignKey(c => c.LanguageId);
        }
    }
}
