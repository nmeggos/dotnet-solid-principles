namespace OpenClosed;

public abstract class Order
{
    public int Id { get; set; }
    
    public string CustomerName { get; set; }
    
    public decimal SubTotalAmount { get; set; }
    
    public decimal TotalAmount { get; set; }

    public abstract void Checkout();
}