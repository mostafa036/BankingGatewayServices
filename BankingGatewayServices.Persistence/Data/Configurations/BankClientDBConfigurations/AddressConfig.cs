using BankingGatewayServices.Domain.Database.BankClientDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BankingGatewayServices.Persistence.Data.Configurations.BankClientDBConfigurations
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            // Table Mapping

            entity.Property(a => a.IsPrimary)
                  .HasDefaultValue(false);

            entity.Property(a => a.AddressType)
                  .HasConversion<int>() // Enum to integer conversion
                  .IsRequired();
        }
    }

}
