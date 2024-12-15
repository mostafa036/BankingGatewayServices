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
    internal class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> entity)
        {


            entity.HasKey(c => c.CountryId);

            entity.Property(c => c.Name)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(c => c.IsoCode)
                  .IsRequired()
                  .HasMaxLength(3);

            entity.HasMany(c => c.Clientes)
                  .WithOne(c => c.Country)
                  .HasForeignKey(c => c.CountryId);
        }
    }
}
