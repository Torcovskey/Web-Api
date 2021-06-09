using Data.Entity;
using Data.Entity.IntermediateEntity;
using Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entity
{
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Status { get; set; }
        public int UserId { get; set; }

        //public enum status
        //{
        //    NotPaid = 0,
        //    Paid = 1
        //}
        //  public List<Product> products { get; set; }
        public List<OrderProducts> OrderProducts { get; set; }
        
    }
}
