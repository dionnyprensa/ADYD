using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    public class FamilyProductConfig : EntityTypeConfiguration<Domain.Entities.FamilyProduct>
    {
        public FamilyProductConfig()
        {

            Property(s => s.StatusEntity)
                .IsRequired();

            HasRequired(s => s.CreatedBy)
                .WithMany(u => u.FamilyProducts)
                .HasForeignKey(s => s.CreatedById);

            HasRequired(s => s.ModifiedBy)
                .WithMany(u => u.FamilyProducts)
                .HasForeignKey(s => s.ModifiedById);

            Property(s => s.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}
