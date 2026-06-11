namespace HotelBookingSystem.ConsoleApp.Models;

public class Customer(string id, string name)
{
    public string Id { get; set; } = id;

    public string Name { get; set; } = name;
}
