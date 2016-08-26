using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    public class ProductConfig : EntityTypeConfiguration<Domain.Entities.Product>
    {
        public ProductConfig()
        {
            ToTable("Products");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Code)
                .HasColumnType("varchar")
                .HasMaxLength(8)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("Idx_Code", 1) { IsUnique = true }))
                .IsRequired();

            Property(p => p.Name)
                .HasColumnType("varchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(p => p.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(64);

            Property(p => p.Cost)
                .HasPrecision(18, 2);

            Property(c => c.Price)
                .HasPrecision(18, 2);

            Property(c => c.Sold);

            HasRequired(p => p.ProductMeasure)
                .WithMany(u => u.ProductsLinked)
                .HasForeignKey(p => p.ProductMeasureId);

            HasRequired(p => p.CreatedBy)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.CreatedById);

            HasRequired(p => p.ModifiedBy)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.ModifiedById);

            Property(p => p.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}