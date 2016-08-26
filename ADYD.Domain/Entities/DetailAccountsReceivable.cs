using System;

namespace ADYD.Domain.Entities
{
    public class DetailAccountsReceivable : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public decimal Due { get; set; }
        public decimal Paid { get; set; }

        public int AccountsReceivableId { get; set; }

        public virtual AccountsReceivable AccountsReceivable { get; set; }

        public Enums.Status StatusEntity { get; set; }

        //Auditoria
        public int CreatedById { get; set; }

        public int ModifiedById { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}