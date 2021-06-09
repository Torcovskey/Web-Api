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
        public string Company { get; set; }
        public string Category { get; set; }
        public string Model { get; set; }
        public int NumberOfProducts { get; set; }
        public int Price { get; set; }
    }
}
