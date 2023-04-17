namespace DevShop.Models.Product;

public class Cart
{
    public int Id { get; set; }
    public double amount { get; set; }
    public List<ItemOrder> product { get; set; }

    public Cart(int id, double amount)
    {
        Id = id;
        this.amount = amount;
        
    }
}

