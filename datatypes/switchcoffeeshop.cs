using System;
class switchcoffeeshop
{
    static void Main()
    {
        bool keepOrdering = true;
        double price = 0;
        double total = 0;
        string receipt = "";
        while (keepOrdering)
        {
            Console.WriteLine("Welcome to Star bucks coffee shop☕🍵 ");
            Console.WriteLine("1.Double Chocolate Chip Frappuccino");
            Console.WriteLine("2. Picco Cappuccino");
            Console.WriteLine("3.Caffe Americano");
            Console.WriteLine("4.Cold coffee");
            Console.WriteLine("5.exit");

            Console.Write("Please enter your choice (1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            string item = "";
            


            switch (choice)
            {
                case 1:
                    price = 462.25;
                    item = "Chocolate Chip Frappuccino";
                    //Console.WriteLine("You selected Chocolate Chip Frappuccino - ₹" + price);
                    break;
                case 2:
                    price = 194.25;
                    item = "Picco Cappuccino";
                    //Console.WriteLine("You selected Picco Cappuccino - ₹" + price);
                    break;
                case 3:
                    price = 309.75;
                    item = "Caffe Americano";
                    //Console.WriteLine("You selected Caffe Americano - ₹" + price);
                    break;
                case 4:
                    price = 404.25;
                    item = "cold coffee";
                   // Console.WriteLine("You selected  cold coffee - ₹" + price);
                    break;
                case 5:

                   
                    keepOrdering = false;

                    break;

                //default:
                //    Console.WriteLine("Invalid selection. Please choose a number between 1 and 4.");
                //    break;

            }

            if (keepOrdering)
            {
               
                //Console.WriteLine("\nPress any key to return to the menu...");
                //Console.ReadKey();
                receipt += $"{item} - ₹{price}\n";
                total = total+price;
                Console.WriteLine($"Added {item} to your order.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        Console.Clear();
        Console.WriteLine("=== Your Receipt ===");
        Console.WriteLine(receipt);
        Console.WriteLine($"Total: ₹{total:F2}");//fixed pint to two variables
        


        // Payment details
        Console.Write("\nEnter payment amount: ₹");
        double payment = Convert.ToDouble(Console.ReadLine());

        if (payment >= total)
        {
            double change = payment - total;
            Console.WriteLine($"Payment accepted. Change: ₹{change:F2}");
        }
        else
        {
            Console.WriteLine("Insufficient payment. Please try again.");
        }

        Console.WriteLine("Thank you for visiting  your starbucks coffe shop !");
    }
}

   


