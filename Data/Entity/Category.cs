using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Data.Interfaces;

namespace Data.Entity
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }

        //Navigation
        public List<Product> Products { get; set; }
    }
}
