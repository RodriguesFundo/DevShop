using DevShop.Models.Product;

namespace DevShop;

    public class Cart
    {
        public int Id { get; set; }
        public double amount { get; set; }
        public Product [] product { get; set; }

    }

