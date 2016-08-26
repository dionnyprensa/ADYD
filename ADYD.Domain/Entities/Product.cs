using System;
using System.Collections.Generic;

namespace ADYD.Domain.Entities
{
    public class Product : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int Sold { get; set; }

        public int Stock
        {
            get
            {
                return ProductRegistry.ProductMeasure.QuantityByUnitMesuare * ProductRegistry.Quantity;
            }
            set { }
        }

        public int FamilyProductsId { get; set; }
        public int ProductMeasureId { get; set; }
        
        public virtual ICollection<DetailSale> DetaildSales { get; set; }
        public virtual FamilyProduct FamilyProducts { get; set; }
        public virtual ICollection<ProductRegistry> ProductRegistries { get; set; }
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