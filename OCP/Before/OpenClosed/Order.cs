namespace OpenClosed;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; set; }
    
    public void Checkout()
    {
        Console.WriteLine($"Order {Id} for Customer {CustomerName} has been checked out.");
    }
}