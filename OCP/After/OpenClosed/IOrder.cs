namespace OpenClosed;

public interface IOrder
{
    int Id { get; set; }
    
    string CustomerName { get; set; }
    
    decimal SubTotalAmount { get; set; }
    
    decimal TotalAmount { get; }

    void Checkout();
}