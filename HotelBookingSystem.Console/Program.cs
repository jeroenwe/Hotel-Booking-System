using HotelBookingSystem.ConsoleApp.Interfaces;
using HotelBookingSystem.ConsoleApp.Models;
using HotelBookingSystem.ConsoleApp.Services;

namespace HotelBookingSystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookingService bookingService = new BookingService();
            const decimal pricePerNight = 100m;
            var customer = new Customer("CUST-001", "John Doe");

            Console.WriteLine("=== Hotel Booking Cost Calculator ===");
            Console.WriteLine($"Standard Room Price: ${pricePerNight} per night\n");

            Console.Write("Please enter the number of nights you want to book: ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int nights))
            {
                decimal baseCost = nights * pricePerNight;
                decimal totalCost = bookingService.CalculateTotalCost(customer, nights, pricePerNight);
                decimal discountApplied = baseCost - totalCost;

                Console.WriteLine("\n--- Booking Summary ---");
                Console.WriteLine($"Duration: {nights} night(s)");
                Console.WriteLine($"Base Price: ${baseCost:F2}");

                Console.WriteLine(discountApplied > 0
                    ? $"Discount Applied: -${discountApplied:F2}"
                    : "Discount Applied: $0.00 (No discount available for this duration)");

                Console.WriteLine($"Total Cost: ${totalCost:F2}");
                Console.WriteLine("-----------------------");
            }
            else
            {
                Console.WriteLine("\n[Error] Invalid input. Please enter a valid whole number for the number of nights.");
            }
        }
    }
}
