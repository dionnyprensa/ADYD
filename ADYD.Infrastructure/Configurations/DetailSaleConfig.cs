using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    public class DetailSaleConfig : EntityTypeConfiguration<Domain.Entities.DetailSale>
    {
        public DetailSaleConfig()
        {
            ToTable("DetailsSales");

            //HasKey(d => d.Id);

            //Property(d => d.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            //    .HasColumnName("Id");

            Property(d => d.Quantity)
                .IsRequired();

            Property(d => d.SaleId)
                .IsRequired();

            Property(d => d.ProductId)
                .IsRequired();

            Property(s => s.StatusEntity)
                .IsRequired();

            HasRequired(d => d.Sale)
                .WithMany(s => s.DetailsdSale)
                .HasForeignKey(ds => ds.SaleId);

            HasRequired(d => d.Product)
                .WithMany(p => p.DetaildSales)
                .HasForeignKey(s => s.ProductId);
        }
    }
}