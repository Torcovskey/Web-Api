using Data.Entity.IntermediateEntity;
using Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entity
{
    public class Basket : IEntity
    {
        [Key]
        public int Id { get; set; }
        public List<Product> Products { get; set; }

        //Navigation
        public Account Account { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }
    }
}
