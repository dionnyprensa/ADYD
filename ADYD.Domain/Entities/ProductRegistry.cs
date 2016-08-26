using System;

namespace ADYD.Domain.Entities
{
    public class ProductRegistry : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public int ProductMeasureId { get; set; }

        public virtual Product Product { get; set; }
        //Medida de los productos: Kg, Cajas, Lbs, Caja de XS y etc,. Ya digitado.
        public virtual ProductMeasure ProductMeasure { get; set; }

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