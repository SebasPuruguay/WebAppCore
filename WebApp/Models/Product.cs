namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public double Discount { get; set; } 
        public string? IsActive { get; set; }


    }
}
