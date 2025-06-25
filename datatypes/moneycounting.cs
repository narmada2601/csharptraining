using System;
 class moneycounting
    {
        static void Main()
        {
       
            Console.WriteLine("Enter the number of notes:");

            Console.Write("₹2000 notes: ");
            int notes2000 = int.Parse(Console.ReadLine());

            Console.Write("₹500 notes: ");
            int notes500 = int.Parse(Console.ReadLine());

            Console.Write("₹200 notes: ");
            int notes200 = int.Parse(Console.ReadLine());

            Console.Write("₹100 notes: ");
            int notes100 = int.Parse(Console.ReadLine());

            Console.Write("₹50 notes: ");
            int notes50 = int.Parse(Console.ReadLine());

            Console.Write("₹20 notes: ");
            int notes20 = int.Parse(Console.ReadLine());

            Console.Write("₹10 Rupees: ");
            int coins10 = int.Parse(Console.ReadLine());

            Console.Write("₹5 coins: ");
            int coins5 = int.Parse(Console.ReadLine());

           int total = (notes2000 * 2000) + (notes500 * 500) + (notes200 * 200) +
                        (notes100 * 100) + (notes50 * 50) + (notes20 * 20) +
                        (coins10 * 10) + (coins5 * 5) ;

            Console.WriteLine($"\nTotal amount: ₹{total}");
        }
    }



