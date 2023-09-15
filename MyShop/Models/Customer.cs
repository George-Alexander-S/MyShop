namespace MyShop.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public String Name { get; set; } = string.Empty;
    public String Address { get; set; } = string.Empty;
    // navigation property
    public virtual List<Order>? Orders { get; set; }
}