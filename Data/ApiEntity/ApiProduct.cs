using Data.Entity;
using Data.Entity.IntermediateEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.ApiEntity
{
    public class ApiProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public string Model { get; set; }
        public int NumberOfProducts { get; set; }
        public int Price { get; set; }

        //Navigation
        public Category Category { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }
    }
}
