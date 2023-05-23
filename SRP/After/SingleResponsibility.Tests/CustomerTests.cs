namespace SingleResponsibility.Tests;

public class CustomerTests
{
    [Fact]
    public void WhenCreatingCustomer_Should_HaveNameAndEmailAndType()
    {
        // Arrange
        string name = "John Doe";
        string email = "johndoe@example.com";
        string message = "Test message";
        CustomerType customerType = CustomerType.DirectRetail;

        // Act
        Customer customer = new Customer(name, email, customerType);

        // Assert
        // Verify that the customer was saved (assert on some data store or repository)
        // Verify that the email was sent (assert on some email service or provider)

        customer.Name.Should().Be(name);
        customer.Email.Should().Be(email);
        customer.CustomerType.Should().Be(customerType);
    }
}