using HotelBookingSystem.ConsoleApp.Models;

namespace HotelBookingSystem.ConsoleApp.Interfaces;

public interface IBookingService
{
    decimal CalculateTotalCost(Customer customer, int nights, decimal pricePerNight);
}
