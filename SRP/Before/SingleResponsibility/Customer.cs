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
    public decimal Discount { get; private set; } 
    
    public CustomerType CustomerType { get; set; }

    public void PlaceOrder(decimal amount)
    {
        CalculateDiscount(amount);
    }

    public void SaveAndSendEmail(string message)
    {
        // Save customer to datastore
        // Send email to customer
    }

    public void CalculateDiscount(decimal amount)
    {
        if (CustomerType == CustomerType.DirectRetail)
        {
            Discount = amount * 0.1m;
        }
        else if (CustomerType == CustomerType.Business)
        {
            Discount = amount * 0.2m;
        }
    }
}