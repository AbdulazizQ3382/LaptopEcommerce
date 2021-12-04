using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LaptopEcommerce.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int CustomerID { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public double MaxPrize { get; set; }
        public Customer Customer { get; set; }

        // no navigation for OrderedProducts because it has no key
    }
}
