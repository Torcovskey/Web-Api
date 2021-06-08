using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Data.Interfaces;

namespace Data.Entity
{
    public class Account : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Login { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
        public bool Admin { get; set; }

        public int BasketId { get; set; }

        //Navigation
        public Basket Basket { get; set; }
    }
}
