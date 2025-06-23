using System;

   class arrayTypes
    {
    static void Main()
    {
        //one dimenstional
        string[] weekdays = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
        Console.WriteLine(weekdays);//system.string[]
        foreach (var week in weekdays)
        {
            Console.WriteLine( week +" ");//line by line days ina week
        }
        //2d
        int[,] numbers = { {1,2,3},
                           {6,7,8 }
                         };
        Console.WriteLine(numbers [0,2]);//print out as 3.
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
        //jagged array-array of arrays :int[][] arr = { new int[] { 1, 3, 5, 7, 9 },
        //                                              new int[] { 2, 4, 6, 8 } };
    int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };




    }
}

