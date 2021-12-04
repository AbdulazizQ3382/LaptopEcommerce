using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopEcommerce.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Details { get; set; }
        public string ImgUrl { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [Range(0,15000.0)]
        public double Prize { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Items { get; set; }

        // no navigation for OrderedProducts because it has no key
        
    }
}
