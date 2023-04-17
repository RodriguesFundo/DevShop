using DevShop.Models.Product;

namespace DevShop.Models;

//Pedidos
public class Order
{
    public int orderNumber { get; set; }
    public Customer customer { get; set; }
    public Cart idCart { get; set; }
    public double amount { get; set; }
    public DateTime issueDate { get; set; }

    public Order(int orderNumber, Customer customer, Cart idCart, double amount, DateTime issueDate)
    {
        this.orderNumber = orderNumber;
        this.customer = customer;
        this.idCart = idCart;
        this.amount = amount;
        this.issueDate = issueDate;
    }

    public void payment() { }

}
