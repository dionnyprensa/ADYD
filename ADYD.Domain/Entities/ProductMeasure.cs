using System;
using System.Collections.Generic;

namespace ADYD.Domain.Entities
{
    public class ProductMeasure : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuantityByUnitMesuare { get; set; }

        public int ProductRegistryId { get; set; }

        public virtual ProductRegistry ProductRegistry { get; set; }
        public virtual ICollection<Product> ProductsLinked { get; set; }

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