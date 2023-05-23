namespace SingleResponsibility.Tests;

public class CustomerDiscountTests
{
    [Fact]
    public void WhenCalculatingDiscountForDirectRetailCustomer_Should_ReturnCorrectValue()
    {
        // Arrange
        CustomerType customerType = CustomerType.DirectRetail;
        decimal amount = 100m;
        CustomerDiscount customerDiscount = new CustomerDiscount();
        string percentage = "10%";

        // Act
        customerDiscount.Calculate(customerType, amount);

        // Assert
        customerDiscount.Value.Should().Be(10m);
        customerDiscount.Percentage.Should().Be(percentage);
    }
}