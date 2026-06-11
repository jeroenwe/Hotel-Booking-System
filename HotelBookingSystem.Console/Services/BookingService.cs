using HotelBookingSystem.ConsoleApp.Interfaces;
using HotelBookingSystem.ConsoleApp.Models;

namespace HotelBookingSystem.ConsoleApp.Services;

public class BookingService : IBookingService
{
    public decimal CalculateTotalCost(Customer customer, int nights, decimal pricePerNight)
    {
        if (nights <= 0 || pricePerNight <= 0 || customer == null)
        {
            return 0;
        }

        return nights * pricePerNight;
    }
}
