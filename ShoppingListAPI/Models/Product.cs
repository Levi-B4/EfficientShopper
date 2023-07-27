using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingListAPI.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [Comment("Short description to clarify product if wanted")]
        public string? Description { get; set; }
        [RegularExpression("^(\\d{1, 3}(\\,\\d{3})*|(\\d+))(\\.\\d{2})?$")]
        public decimal? Price { get; set; }
        public decimal Quantity { get; set; }
        [Comment("Unit of measurement for quantity; gallons, pounds, feet, ect")]
        public string? QuantityUnit { get; set; }
        [Comment("Used to show user if product has been purchased or not")]
        public Boolean IsBought { get; set; }
    }
}