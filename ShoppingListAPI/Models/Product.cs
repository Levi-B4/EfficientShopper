namespace ShoppingListAPI.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public string? quantityUnit { get; set; }
        
    }
}
