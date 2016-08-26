namespace ADYD.Domain.Entities
{
    public class DetailSale
    {
        public int Quantity { get; set; }

        public int SaleId { get; set; }
        public int ProductId { get; set; }

        public Enums.Status StatusEntity { get; set; }

        public virtual Sale Sale { get; set; }
        public virtual Product Product { get; set; }
    }
}