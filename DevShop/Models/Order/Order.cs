
namespace DevShop.Models.Customer;

//Pedidos
public class Order
{
    public int orderNumber { get; set; }
    public Customer customer { get; set; }
    public Cart idCart { get; set; }
    public double amount { get; set; }
    public DateTime issueDate { get; set; }


    public void payment() { }

}
