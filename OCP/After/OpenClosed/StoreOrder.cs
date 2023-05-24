namespace OpenClosed;

public class StoreOrder : IOrder
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public decimal SubTotalAmount { get; set; }

    public decimal TotalAmount { get; private set; }

    public void Checkout()
    {
        TotalAmount = SubTotalAmount;
        Console.WriteLine($"Order {Id} for {CustomerName} has been checked out.");
        Console.WriteLine($"Subtotal: {SubTotalAmount:C}");
        Console.WriteLine($"Total: {TotalAmount:C}{Environment.NewLine}");
    }
}