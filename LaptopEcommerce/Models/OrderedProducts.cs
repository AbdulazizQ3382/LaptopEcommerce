using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopEcommerce.Models
{
    public class OrderedProducts
    {
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }

    }
}
