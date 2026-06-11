using HotelBookingSystem.ConsoleApp.Interfaces;
using HotelBookingSystem.ConsoleApp.Models;
using HotelBookingSystem.ConsoleApp.Services;

namespace HotelBookingSystem.Tests;

public class BookingServiceTests
{
    [Fact]
    public void CalculateTotalCost_RegularStay_ReturnsCorrectPrice()
    {
        IBookingService service = new BookingService();
        var customer = new Customer("CUST-001", "John Doe");
        decimal total = service.CalculateTotalCost(customer, 3, 100m);
        Assert.Equal(300m, total);
    }
}
