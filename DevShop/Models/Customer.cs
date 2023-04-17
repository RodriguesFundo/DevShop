namespace DevShop.Models;

public class Customer
{
    public int Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string country { get; set; }
    public string adress { get; set; }
    public string city { get; set; }
    public byte CEP { get; set; }

    public Customer(int id, string firstName, string lastName, string email, string country, string adress, string city, byte cEP)
    {
        Id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.country = country;
        this.adress = adress;
        this.city = city;
        CEP = cEP;
    }
}
