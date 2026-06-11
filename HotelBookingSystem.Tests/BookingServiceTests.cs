using HotelBookingSystem.ConsoleApp.Interfaces;
using HotelBookingSystem.ConsoleApp.Services;

namespace HotelBookingSystem.Tests;

public class BookingServiceTests
{
    [Fact]
    public void CalculateTotalCost_RegularStay_ReturnsCorrectPrice()
    {
        IBookingService service = new BookingService();
        decimal total = service.CalculateTotalCost(3, 100m);
        Assert.Equal(300m, total);
    }
}
