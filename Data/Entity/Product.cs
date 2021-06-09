using Data.Entity.IntermediateEntity;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entity
{
    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        [MaxLength(30)]
        public string Model { get; set; }
        public int NumberOfProducts { get; set; }
        public int Price { get; set; }

        //Navigation
        public Company Company { get; set; }
        public Category Category { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }
        public List<OrderProducts> OrderProducts { get; set; }
    }
}
