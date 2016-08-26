using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    public class ProductMeasureConfig : EntityTypeConfiguration<Domain.Entities.ProductMeasure>
    {
        public ProductMeasureConfig()
        {
            ToTable("ProductMeasures");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(c => c.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(64);

            Property(pm => pm.QuantityByUnitMesuare)
                .IsRequired();

            Property(pm => pm.StatusEntity)
                .IsRequired();

            HasRequired(pm => pm.CreatedBy)
                .WithMany(u => u.ProductProductMeasures)
                .HasForeignKey(s => s.CreatedById);

            HasRequired(pm => pm.ModifiedBy)
                .WithMany(u => u.ProductProductMeasures)
                .HasForeignKey(s => s.ModifiedById);

            Property(pm => pm.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}