using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingListAPI.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        [MaxLength(30)]
        public string name { get; set; }
        [Comment("Short description to clarify product if wanted")]
        public string? description { get; set; }
        public decimal? price { get; set; }
        public decimal quantity { get; set; }
        public string? quantityUnit { get; set; }
        
    }
}
