namespace ProductShop.Models
{
    using System.Collections.Generic;

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public int SellerId { get; set; }
        public User Seller { get; set; } = null!;

        public int? BuyerId { get; set; }
        public virtual User? Buyer { get; set; }

        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } 
            = new List<CategoryProduct>();
    }
}