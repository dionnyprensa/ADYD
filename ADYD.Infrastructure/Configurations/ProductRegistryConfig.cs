using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    public class ProductRegistryConfig : EntityTypeConfiguration<Domain.Entities.ProductRegistry>
    {
        public ProductRegistryConfig()
        {
            ToTable("ProductRegistries");

            HasKey(pr => pr.Id);

            Property(pr => pr.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(pr => pr.Quantity)
                .IsRequired();

            Property(pr => pr.Date)
                .IsRequired();

            HasRequired(pr => pr.ProductMeasure)
                .WithRequiredDependent(pm => pm.ProductRegistry);

            HasRequired(pr => pr.Product)
                .WithMany(p => p.ProductRegistries)
                .HasForeignKey(prp => prp.ProductId);

            Property(s => s.StatusEntity)
                .IsRequired();

            HasRequired(s => s.CreatedBy)
                .WithMany(u => u.ProductRegistries)
                .HasForeignKey(s => s.CreatedById);

            HasRequired(s => s.ModifiedBy)
                .WithMany(u => u.ProductRegistries)
                .HasForeignKey(s => s.ModifiedById);

            Property(cn => cn.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}