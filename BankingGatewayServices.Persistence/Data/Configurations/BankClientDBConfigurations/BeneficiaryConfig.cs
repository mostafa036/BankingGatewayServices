
using BankingGatewayServices.Domain.Database.BankClientDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BankingGatewayServices.Persistence.Data.Configurations.BankClientDBConfigurations
{
    public class BeneficiaryConfig : IEntityTypeConfiguration<Beneficiary>
    {
        public void Configure(EntityTypeBuilder<Beneficiary> entity)
        {
            // Primary Key
            entity.HasKey(b => b.BeneficiaryID);

            // Property Configurations
            entity.Property(b => b.BeneficiaryName).IsRequired().HasMaxLength(200);

            entity.Property(b => b.AccountNumber).IsRequired().HasMaxLength(50);

            entity.Property(b => b.BankName).IsRequired().HasMaxLength(100);

            entity.Property(b => b.BeneficiaryType).HasConversion<string>().IsRequired();

            entity.Property(b => b.CreatedAt).HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAdd();

            entity.Property(b => b.UpdatedAt).HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAddOrUpdate();

            // Relationship Configurations
            entity.HasOne(b => b.Clientes).WithMany().HasForeignKey(b => b.ClientID);
        }
    }
}
