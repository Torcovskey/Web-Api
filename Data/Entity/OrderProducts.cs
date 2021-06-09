using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity.IntermediateEntity
{
    public class OrderProducts
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
