namespace SingleResponsibility;

public class Customer
{
    public Customer(string name, string email, CustomerType customerType)
    {
        Name = name;
        Email = email;
        CustomerType = customerType;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public CustomerDiscount Discount { get; private set; } 
    
    public CustomerType CustomerType { get; set; }

    public void PlaceOrder(decimal amount)
    {
        Discount = new CustomerDiscount();
        Discount.Calculate(CustomerType, amount);
    }
}