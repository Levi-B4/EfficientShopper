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
        [RegularExpression("^(\\d{1, 3}(\\,\\d{3})*|(\\d+))(\\.\\d{2})?$")]
        public decimal? price { get; set; }
        public decimal quantity { get; set; }
        [Comment("Unit of measurement for quantity; gallons, pounds, feet, ect")]
        public string? quantityUnit { get; set; }
    }
}


//create new product that returns the errro and test for taht 
//assert for exception (pass or fail based off that

//add in readme to do ef-database update (can find more info for it online at getting started with ef)