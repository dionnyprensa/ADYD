using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    public class AccountsReceivableConfig : EntityTypeConfiguration<Domain.Entities.AccountsReceivable>
    {
        public AccountsReceivableConfig()
        {
            ToTable("AccountsReceivable");

            HasKey(ar => ar.Id);

            Property(ar => ar.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(ar => ar.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            HasRequired(ar => ar.Sale)
                .WithRequiredPrincipal(s => s.AccountsReceivable);

            HasRequired(s => s.CreatedBy)
                .WithMany(u => u.AccountsReceivable)
                .HasForeignKey(s => s.CreatedById);

            HasRequired(s => s.ModifiedBy)
                .WithMany(u => u.AccountsReceivable)
                .HasForeignKey(s => s.ModifiedById);

            Property(cn => cn.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}