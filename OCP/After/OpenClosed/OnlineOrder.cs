namespace OpenClosed;

public class OnlineOrder : IOrder
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public decimal SubTotalAmount { get; set; }
    public decimal TotalAmount { get; set; }

    public decimal Discount { get; set; } = 1.00m;

    public void Checkout()
    {
        decimal promotionDiscount = 0.20m;
        
        TotalAmount = SubTotalAmount - (SubTotalAmount * Discount);
        
        Console.WriteLine($"Order {Id} for {CustomerName} has been checked out.");
        Console.WriteLine($"Subtotal: {SubTotalAmount:C}");
        Console.WriteLine($"Total: {TotalAmount:C}");
        Console.WriteLine($"You saved {SubTotalAmount - TotalAmount:C}{Environment.NewLine}");
    }
}