using System;
using System.Diagnostics;

class task1Methods
{
    static void Main()
    {
        Console.WriteLine("Choose furniture  type: sofas/ chairs/fans/none");
        string discountType = Console.ReadLine();


        Console.WriteLine("Enter the item :");
        string item = Console.ReadLine();

        Console.WriteLine("Enter quantity:");
        int quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter price per unit:");
        double price = double.Parse(Console.ReadLine());

       

        double total = CalculateTotal(item, quantity, price);//as return type is double
        string discountCategory = GetDiscountCategory(total);

        //calling method
        double finalAmount =ApplyDiscount(total, discountType);

       

        Console.WriteLine($" total amount after discount ₹{finalAmount}");

    }
    static string GetDiscountCategory(double total)
    {
        if (total >= 1000)
            return "sofas";
        else if (total >= 2000)
            return "chairs";
        else if (total >= 1000)
            return "fans";
        else
            return "default";
    }
    static double CalculateTotal(string Name, int quantity, double price)//method name with parameters
    {
        //double total = quantity * price;
        //Console.WriteLine($" ₹{total}");
        return quantity * price;
    }
    static double  ApplyDiscount(double total, string discountType)
    {
        switch (discountType)
        {
            case  "sofas":
                    Console.WriteLine(" 10% discount applied! on sofas ");
                    return total * 0.9;

            case "chairs":
                Console.WriteLine(" 20% discount applied! on chairs");
                return total * 0.8; // 20% off
            case "fans":
                Console.WriteLine(" 10% discount applied! on fans");
                return total * 0.9;//10% off
             default:
                   Console.WriteLine(" No discount applied.");
                  return total;

                    }



    }
}