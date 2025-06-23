using System;
using System.ComponentModel;


class stringFormating
    {
    static void Main()
    {
        
        string name= "Ram";
        Console.WriteLine("{0}",name);

        int val = 1234;
        Console.WriteLine("{0:D} {0:N} {0:G} {0:F}",val);


        decimal value2 = 1234.1234m;
        Console.WriteLine("{0:E} {0:N} {0:G} {0:F}", value2);

        //precision formating by adding number
        Console.WriteLine("{0:D6} {0:N2} {0:G3} {0:F1}", val);
        Console.WriteLine("{0:E2} {0:N3} {0:G2} {0:F1}", value2);

        int[] quater = { 1, 2, 3, 4 };
        int[] sales = { 10000, 20000, 30000, 40000 };
        double[] intmixpic = { .326,.798,.345,.456 };

        Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", quater[0], quater[1], quater[2], quater[3]);//align and spacing 1 2 3 4

       Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", sales[0], sales[1], sales[2], sales[3]);
        Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P0}", intmixpic[0], intmixpic[1], intmixpic[2], intmixpic[3]);//P1 PRINT 1VALUE;
        //TO PRINT PERCENTAGE
    }
}

