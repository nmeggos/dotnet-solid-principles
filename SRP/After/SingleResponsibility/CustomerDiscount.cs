using System.Globalization;

namespace SingleResponsibility;

public class CustomerDiscount
{
    public decimal Value { get; set; }
    public string Percentage { get; private set; }
    
    public void Calculate(CustomerType customerType, decimal amount)
    {
        if (customerType == CustomerType.DirectRetail)
        {
            Value = amount * 0.1m;
            Percentage = "10%";
        }
        else if (customerType == CustomerType.Business)
        {
            Value = amount * 0.2m;
            Percentage = "20%";
        }
    }
}