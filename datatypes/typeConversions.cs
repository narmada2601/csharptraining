using System;
using System.IO;
class typeConversions
    {
        static void Main()
        {
        //implicit-This happens automatically when there's no risk of data loss—like converting an int to a double.
        int number = 100;
        double bigNumber = number;//implicity converting int to double.
        Console.WriteLine("implicity conversion"+bigNumber);

        //explicit-Used when there’s potential for data loss, like converting a double to an int.
        double value = 99.99;
        int result = (int)value; // Explicit conversion, decimal part is lost
        Console.WriteLine("explicit conversion" + result);
        //converting string to int
        string str = "123";
        int num=Convert.ToInt32(str);
        int num1=int.Parse(str);
        Console.WriteLine("converting string to int using convert: " +num);//123
        Console.WriteLine("converting string to int using parse: " + num);//123
        Console.WriteLine("checking type" + num.GetType());//System.int32

        //converting int to string
        int noOfBooks = 12;
        string bookscount=noOfBooks.ToString();
        Console.WriteLine("converting to int to string" + bookscount);

        //using null
        string nullbaleString = null;
        //int output1 = int.Parse(nullbaleString);
        int output1 = Convert.ToInt32(nullbaleString);  //returns emplty

        Console.WriteLine(output1);

        // //value type is numeric as null
        // string nullable = null;
        //int checkingnull= int.Parse(nullable);
        // Console.WriteLine("testing null"+checkingnull);

        //explaining in detail about parse and convert.intto32
        //int.Parse(): Converts a string to an integer but throws an exception
        //if the input is null or not a valid number.

        string name = "Anushka";
        string unKnown = null;
        //using parse
        int heroine = int.Parse(name);
        Console.WriteLine("using parse"+heroine);

        Console.WriteLine("checkung null"+int.Parse(unKnown));//exception

        //Convert.ToInt32(): Converts various types to an integer
        //and returns 0 if the input is null, instead of throwing an exception.

        Console.WriteLine(Convert.ToInt32(name));
        Console.WriteLine(Convert.ToInt32(unKnown));


        //converting to date
        string dateInput = "2025-06-19";
        DateTime date = DateTime.Parse(dateInput);
        Console.WriteLine(date);

         byte[] uploading=File.ReadAllBytes("resume.pdf");
        string byte64=Convert.ToBase64String(uploading);//to upload files and byte array




    }
}

