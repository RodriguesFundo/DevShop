namespace DevShop.Models.Product;

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

    public Product(int id, string name, double price, string description, string category, string picLink, bool inPromotion, bool inStock, int qntStock)
    {
        Id = id;
        this.name = name;
        this.price = price;
        this.description = description;
        this.category = category;
        this.picLink = picLink;
        this.inPromotion = inPromotion;
        this.inStock = inStock;
        this.qntStock = qntStock;
    }
}
