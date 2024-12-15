using BankFlowServices.Domain.Entities.BankClientDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Persistence.Data.Configurations.BankClientDBConfigurations
{
    public class ClientFeedbackConfig : IEntityTypeConfiguration<ClientFeedback>
    {
        public void Configure(EntityTypeBuilder<ClientFeedback> entity)
        {


            // Primary Key
            entity.HasKey(cf => cf.FeedbackID);

            // Property Configurations
            entity.Property(cf => cf.FeedbackID)
                  .IsRequired();

            entity.Property(cf => cf.Comments)
             .IsRequired()
             .HasMaxLength(1000); // Example: Limiting comments to 1000 characters

            // Relationship Configurations
            entity.HasOne(cf => cf.Clientes)
                  .WithMany(c => c.ClientFeedbacks) // One-to-Many relationship
                  .HasForeignKey(cf => cf.CientID);


        }
    }
}
