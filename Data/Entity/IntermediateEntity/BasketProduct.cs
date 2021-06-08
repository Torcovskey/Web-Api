using Data.Entity;
using Data.Interfaces;

namespace Data.Entity.IntermediateEntity
{
    public class BasketProduct 
    {
        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
