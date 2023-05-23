namespace OpenClosed;

public class StoreOrder : Order
{
    public override void Checkout()
    {
        TotalAmount = SubTotalAmount;
        Console.WriteLine($"Order {Id} for {CustomerName} has been checked out.");
        Console.WriteLine($"Subtotal: {SubTotalAmount:C}");
        Console.WriteLine($"Total: {TotalAmount:C}{Environment.NewLine}");
    }
}