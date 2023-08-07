using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorECommerce.Shared
{
    public class Product
    {
        public long Id { get; set; } 
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Price { get; set; }
    }
}
