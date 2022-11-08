namespace DevShop.Models.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string picLink { get; set; }
        public bool inPromotion { get; set; }
        public bool inStock { get; set; }
        public int qntStock { get; set; }

    }
}
