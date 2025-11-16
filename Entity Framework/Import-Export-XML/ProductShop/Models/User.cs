namespace ProductShop.Models
{
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string LastName { get; set; } = null!;

        public int? Age { get; set; }

        public virtual ICollection<Product> ProductsSold { get; set; } 
            = new List<Product>();
        public virtual ICollection<Product> ProductsBought { get; set; }
            = new List<Product>();
    }
}