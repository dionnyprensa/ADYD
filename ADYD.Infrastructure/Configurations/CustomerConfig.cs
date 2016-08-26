using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    public class CustomerConfig : EntityTypeConfiguration<Domain.Entities.Customer>
    {
        public CustomerConfig()
        {
            ToTable("Customers");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.FirstName)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.LastName)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(c => c.Identification)
                .HasColumnType("nvarchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(c => c.Phone)
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();

            Property(c => c.Address)
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsOptional();

            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(32)
                .IsOptional();

            Property(c => c.Discount)
                .HasPrecision(18, 2)
                .IsOptional();

            Property(c => c.HasAccountsReceivable)
                .IsOptional();

            Property(c => c.CustomerType)
                .IsRequired();

            HasRequired(s => s.CreatedBy)
                .WithMany(u => u.Customers)
                .HasForeignKey(s => s.CreatedById);

            HasRequired(s => s.ModifiedBy)
                .WithMany(u => u.Customers)
                .HasForeignKey(s => s.ModifiedById);

            Property(cn => cn.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}