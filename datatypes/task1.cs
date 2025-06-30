using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
class task1
    {
    static void Main()
    {
        string[] empNames = { "john", "Robert", "chandra", "peter" };//preparing the string array
        //to get the third employee from the array
        Console.WriteLine("The third employee is :" + empNames[3]);//peter
        // to check  second and third employee equal or not
        if (empNames[2] == empNames[3])
        {
            Console.WriteLine("Employees  names are equal");

        }
        else
        {
            Console.WriteLine(" Employees names are not equal");//not equal
        }
        //To check employee names starts with "j" in the array 
        foreach (string names in empNames)
        {
            if (names.StartsWith("j"))
            {
                Console.WriteLine("Employee name start with j are:" + names);//john
            }
        }
        // Convert Employees List into single String
        //string[] empNames = { "john", "Robert", "chandra", "peter" };
        string Employees = string.Join(",", empNames);
        Console.WriteLine("All employee names: " + Employees);//john,robert,chandra,peter



        //Replace the “Robert” with “Peter” in String
        string NamesUpdated = Employees.Replace("Robert", "Peter");
        Console.WriteLine("the updated names in my list are: " + NamesUpdated); //john,peter,chandra,peter

        //to get employees whose name length is 4
        ///<summary>
        ///for-when you know the index,we can access and modify based on index
        ///foreach-when you want to itterate through a collection,we can display and check the values
        ///</summary>
        Console.WriteLine("..............we are using for loop...........");
        for (int i = 0; i < empNames.Length; i++)
        {
            if (empNames[i].Length > 4)
            {
                Console.WriteLine(empNames[i]);
            }

        }
        Console.WriteLine("..............we are using for each............");
        foreach (string names in empNames)
        {
            if (names.Length > 4)
            {
                Console.WriteLine("the employees whose names with more than 4 characters are:" + names);
            }
        }
        ///<summary>
        ///loops checks till the condition is false
        ///
        ///</summary>
        string password = "";
        while (password != "narmada")//till suceess the loop repeats
        {
            Console.WriteLine("enter your  password");
            password = Console.ReadLine();
        }
        Console.WriteLine("login success");
        //do while----executes the block atleast once even if the condition is true..
        string choice;
        do
        {

            Console.WriteLine("enter your  username");
            string Username = Console.ReadLine();

            Console.WriteLine("enter your  password");
            string Password = Console.ReadLine();


            if (Username == "likhil" && password == "likhil123")//true true means true
            {
                Console.WriteLine("login sucess");
            }
            else if (Username == "likhil" || password == "likhil")//f f- f
            {
                Console.WriteLine("try again");
            }
            else
            {
                Console.WriteLine("❌ Access denied.");
            }

            Console.Write("Do you want to try again? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        }
        while (choice == "yes");

        ///<summary>
        ///floating data types:float,decimal,double
        /// used to store the decimal values
        ///</summary>
        float[] Empsalary = { 45555.5f, 340007.23f, 234454.22f, 56755.5f };
        for (int i = 0; i < Empsalary.Length; i++)
        {
            Console.WriteLine("emp floating values " + (i + 1) + ": " + Empsalary[i]);//line by line
        }


        double[] emps = { 245.4,456.78,345.6};
        Console.WriteLine("the double values are:"+emps);//system.double[] so we need to use looping 

        decimal[] demp = {234.5m,345.6m,678.5m };
        Console.WriteLine("the decimal values are" +demp. GetType());//system.decimal[]

        ///<summary>
        ///logical operators:return a true or false result. used in control flow statements like if, while, and for.
        ///logical opeartors are &&,||,!(true return false)
        ///</summary>

        Console.WriteLine(".......Nullable types.......");
        //this operator assigns a value only if the variable is null.

        string books = null;

        string bookName = books?? "wings of fire";
        Console.WriteLine("the bookname  we are assigned is: " + bookName);//wings of fire....
       
       ///<summary>
       ///implicit conversion means assigning smaller(byte,sbyte,short) datatype to larger value
       ///</summary>
        int num = 100;
        float floatNum = num;
        //preparing methods:task1Methods.cs
        


    }
}

