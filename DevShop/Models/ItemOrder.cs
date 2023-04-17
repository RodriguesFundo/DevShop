namespace DevShop.Models.Product;

public class ItemOrder
{
    public int Id { get; set; }
    public Product product { get; set; }
    public int quantity { get; set; }

    public ItemOrder(int id, Product product, int quantity)
    {
        Id = id;
        this.product = product;
        this.quantity = quantity;
    }
}
