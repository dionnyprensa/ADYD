using System;
using System.Collections.Generic;

namespace ADYD.Domain.Entities
{
    public class FamilyProduct : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public virtual ICollection<Product> Products { get; set; }

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