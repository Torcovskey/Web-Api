using Data.Entity;
using Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entity
{
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }

        //public enum status
        //{
        //    NotPaid = 0,
        //    Paid = 1
        //}
        public List<Product> Products { get; set; }
        public int UserId { get; set; }
    }
}
