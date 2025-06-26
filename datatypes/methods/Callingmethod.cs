using System;
 class Callingmethod
    {
        static void Main()
          {
                 add();//calling a method
                multiply();
          }
    static void add()//withour parameters
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("the addition of two numbers are" + (a + b));
   }
    static void multiply()
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("the multiply of two numbers are" + (a * b));
    }



}

