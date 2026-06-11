using HotelBookingSystem.ConsoleApp.Interfaces;

namespace HotelBookingSystem.ConsoleApp.Services;

public class BookingService : IBookingService
{
    public decimal CalculateTotalCost(int nights, decimal pricePerNight)
    {
        if (nights <= 0 || pricePerNight <= 0)
        {
            return 0;
        }

        return nights * pricePerNight;
    }
}
