using System;

 
class movieBooking
{
    static string[] movies = { "Game Changer", "Tandel", "subham", "OG" };
    static int ticketId = 1;
    static void Main()
    {
        showMovies();
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter number of seats: ");
        int seats = int.Parse(Console.ReadLine());

        BookTicket(name, seats);
        MakePayment(name);

    }
    static void showMovies()
    {
        Console.WriteLine("Available Movies:");
        for (int i = 0; i < movies.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {movies[i]}");
        }
    }
    static void BookTicket(string customerName, int seatCount)
    {
        Console.WriteLine($"\nTicket Booked Successfully!");
        Console.WriteLine($"Ticket ID: {ticketId++}");
        Console.WriteLine($"Name: {customerName}");
        Console.WriteLine($"Seats: {seatCount}");
        int seatPrice = 200;
        int totalAmount = seatCount * seatPrice;
        Console.WriteLine("Amount to be paid for movie booking are:" + totalAmount);
    }
    static void MakePayment(string customerName)
    {

        Console.WriteLine($"\n--- Payment Section ---");
        Console.Write("Enter card number (dummy): ");
        string cardNumber = Console.ReadLine();

        Console.Write("Enter CVV (dummy): ");
        string cvv = Console.ReadLine();

        Console.WriteLine("Payment successful! 🎉");
    }




}






