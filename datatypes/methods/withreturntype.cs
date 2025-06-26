using System;
using System.ComponentModel;
class withreturntype
{
    static void Main()
    {
        Console.WriteLine("enter length");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("enter width");
        double width = double.Parse(Console.ReadLine());


        double Area = CalculateArea(length, width);
        Console.WriteLine($"the area of rectangle is {Area} sq units");
    }
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }
}


