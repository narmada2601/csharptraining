using System;


class looping
{
    static void Main()
    {
        var isOpen = true;

        if (!isOpen)
        {
            Console.WriteLine("Sorry, we are closed.");
        }
        else
        {
            Console.WriteLine("Welcome! We are open.");
        }
        Console.WriteLine("....................................................");
        int marks = 95;
        if (marks >= 90)
        {
            if (marks == 100)
            {
                Console.WriteLine("Perfect score!");
            }
            else
            {
                Console.WriteLine("Excellent!");//excellent
            }
        }
        Console.WriteLine(".................using switch...................................");
       
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("A - Add");
                Console.WriteLine("S - Subtract");
                Console.WriteLine("M - Multiply");
                Console.WriteLine("D - Divide");
                Console.WriteLine("Q - Quit");
                Console.Write("Choose an option: ");

                key = Console.ReadKey(true); // true = don't show key on screen
                Console.WriteLine(); // move to next line

                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("You chose Add.");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("You chose Subtract.");
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("You chose Multiply.");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("You chose Divide.");
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);

            } while (key.Key != ConsoleKey.Q);
        
    


}

}
    
    


