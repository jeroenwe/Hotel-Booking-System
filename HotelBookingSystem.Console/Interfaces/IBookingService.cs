namespace HotelBookingSystem.ConsoleApp.Interfaces;

public interface IBookingService
{
    decimal CalculateTotalCost(int nights, decimal pricePerNight);
}
