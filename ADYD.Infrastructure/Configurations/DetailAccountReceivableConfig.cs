using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADYD.Infrastructure.Configurations
{
    internal class DetailAccountReceivableConfig : EntityTypeConfiguration<Domain.Entities.DetailAccountsReceivable>
    {
        public DetailAccountReceivableConfig()
        {
            ToTable("DetailAccountsReceivable");

            HasKey(d => d.Id);

            Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(d => d.Due)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(d => d.Paid)
                .HasPrecision(18, 2)
                .IsRequired();

            HasRequired(dar => dar.AccountsReceivable)
                .WithMany(ar => ar.DetailsAccountsReceivable)
                .HasForeignKey(dar => dar.AccountsReceivableId);

            HasRequired(s => s.CreatedBy)
                .WithMany(u => u.DetailAccountsReceivable)
                .HasForeignKey(s => s.CreatedById);

            HasRequired(s => s.ModifiedBy)
                .WithMany(u => u.DetailAccountsReceivable)
                .HasForeignKey(s => s.ModifiedById);

            Property(cn => cn.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}