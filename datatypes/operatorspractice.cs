using System;
class operatorspractice
    {
    static void Main()
    {
        ////        int Result;
        ////        int Num1 = 20, Num2 = 10;
        ////        // Addition Operation
        ////        Result = (Num1 + Num2);
        ////        Console.WriteLine($"Addition Operator: {Result}");

        ////        // Subtraction Operation
        ////        Result = (Num1 - Num2);
        ////        Console.WriteLine($"Subtraction Operator: {Result}");

        ////        // Multiplication Operation
        ////        Result = (Num1 * Num2);
        ////        Console.WriteLine($"Multiplication Operator: {Result}");

        ////        // Division Operation
        ////        Result = (Num1 / Num2);
        ////        Console.WriteLine($"Division  Operator: {Result}");

        ////        // modulo Operation(The % (Modulos) operator returns the remainder when the first operand is divided by the second)
        ////        Result = (Num1 % Num2);
        ////        Console.WriteLine($"Modulo   Operator: {Result}");


        ////        Console.WriteLine("...........using Assignment opertators...");
        ////         int x = 20;
        ////        x += 10;  //It means x = x + 10 i.e. 15 + 10 = 25
        ////        Console.WriteLine($"Add Assignment Operator: {x}");
        ////        // initialize variable x again
        ////        x = 20;
        ////        x -= 5;  //It means x = x - 5 i.e. 20 - 5 = 15
        ////        Console.WriteLine($"Subtract Assignment Operator: {x}");
        ////        // initialize variable x again
        ////        x = 15;
        ////        x *= 5; //It means x = x * 5  i.e. 15 * 5 = 75
        ////        Console.WriteLine($"Multiply Assignment Operator: {x}");
        ////        // initialize variable x again
        ////        x = 25;
        ////        x /= 5; //It means x = x / 5 i.e. 25 / 5 = 5
        ////        Console.WriteLine($"Division Assignment Operator: {x}");
        ////        // initialize variable x again
        ////        x = 25;
        ////        x %= 5; //It means x = x % 5 i.e. 25 % 5 = 0
        ////        Console.WriteLine($"Modulo Assignment Operator: {x}");

        //Arithematic operators
        int Apples = 10;
        int Orange = 10;
        int total_fruits = Apples + Orange;
        Console.WriteLine($"fruits are" + total_fruits);
        //Relational operators
        int age = 18;
        bool canVote = age >= 18;
        Console.WriteLine("person eligible to vote" + canVote);
        //logical operators
        bool hasTicket = true;
        bool isVIP = false;
        bool canEnter = hasTicket || isVIP; // true
        Console.WriteLine("person has ticket" + canEnter);
        //ternary operator
        int marks = 45;
        string result = (marks >= 50) ? "Pass" : "Fail";
        Console.WriteLine("result" + result);//pass


    }
}

