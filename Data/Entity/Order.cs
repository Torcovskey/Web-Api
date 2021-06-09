using Data.Entity;
using Data.Entity.IntermediateEntity;
using Data.Enum;
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
        public int UserId { get; set; }
        public OrderStatus Status { get; set; }
       
        // Navigation
        public List<OrderProducts> OrderProducts { get; set; }
        
    }
}
