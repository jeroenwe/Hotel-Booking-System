namespace HotelBookingSystem.ConsoleApp.Models;

public class Booking(string customerId, int nights)
{
    public string CustomerId { get; set; } = customerId;

    public int Nights { get; set; } = nights;

    public DateTime BookingDate { get; set; } = DateTime.Now;

    public bool IsCanceled { get; set; } = false;
}

