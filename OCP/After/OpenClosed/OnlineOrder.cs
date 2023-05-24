namespace OpenClosed;

public class OnlineOrder : Order
{
    public override void Checkout()
    {
        decimal promotionDiscount = 0.20m;
        
        TotalAmount = SubTotalAmount - (SubTotalAmount * promotionDiscount);
        
        Console.WriteLine($"Order {Id} for {CustomerName} has been checked out.");
        Console.WriteLine($"Subtotal: {SubTotalAmount:C}");
        Console.WriteLine($"Total: {TotalAmount:C}");
        Console.WriteLine($"You saved {SubTotalAmount - TotalAmount:C}{Environment.NewLine}");
    }
}