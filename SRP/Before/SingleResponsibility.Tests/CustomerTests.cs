using FluentAssertions;

namespace SingleResponsibility.Tests;

public class CustomerTests
{
    [Fact]
    public void WhenPlacingAnOrderAndSavingAndSendingEmail_Should_PlaceOrder_And_Save_Customer_And_Send_Email()
    {
        // Arrange
        string name = "John Doe";
        string email = "johndoe@example.com";
        string message = "Test message";
        CustomerType customerType = CustomerType.DirectRetail;
        decimal discount = 0.1m;

        Customer customer = new Customer(name, email, customerType);

        // Act
        customer.PlaceOrder(new decimal(1.00));
        customer.SaveAndSendEmail(message);

        // Assert
        // Verify that the customer was saved (assert on some data store or repository)
        // Verify that the email was sent (assert on some email service or provider)

        customer.Name.Should().Be(name);
        customer.Email.Should().Be(email);
        customer.Discount.Should().Be(discount);
    }
}