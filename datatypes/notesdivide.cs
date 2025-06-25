using System;
class notesdivide
{
    static void Main()
    {
        bool keepCounting = true;
        while (keepCounting)
        {
            Console.Write("Please enter your choice ");
            Console.WriteLine("1.Enter amount");
            Console.WriteLine("2.Exit");
           
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1 :
                    Console.Write("Enter an amount: ₹");//₹ ctrl+alt+4
                    int amount = int.Parse(Console.ReadLine());
                        int thousands = amount / 1000;
                        int hundreds = (amount % 1000) / 100;
                        int twenties = (amount % 100) / 20;
                        int tens = (amount % 20) / 10;
                    Console.WriteLine($"\n₹{amount} breakdown:");
                    Console.WriteLine($"₹1000 notes: {thousands}");
                    Console.WriteLine($"₹100 notes: {hundreds}");
                    Console.WriteLine($"₹20 notes: {twenties}");
                    Console.WriteLine($"₹10 notes: {tens}");
                    break;

                case 2:
                    keepCounting = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

            }
        }
    }
}



