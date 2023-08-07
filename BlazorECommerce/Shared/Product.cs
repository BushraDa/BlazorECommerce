using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorECommerce.Shared
{
    public class Product
    {
        public long Id { get; set; } 
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; } = String.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Price { get; set; }
    }
}
