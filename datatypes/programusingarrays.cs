using System;
using System.Linq;
using System.Runtime.Remoting.Channels;

class programusingarrays
    {
    static void Main()
    {
        int[] numbers = { 2, 4, 1, 6, 4, 8 };
        Array.Sort(numbers);
        foreach(int s in numbers)
        {
            Console.WriteLine(s +" ");
        }
        string[] names = { "diana", "roma", "vlad", "nic","dizzler","dripper" };
        Array.Sort(names);
        foreach (string name in names)
        {
            Console.WriteLine(name + " ");
        }
        string result = Array.Find(names, name => name.StartsWith("d"));
        Console.WriteLine("the names  starts with d are" + result);

        string[] results1 = Array.FindAll(names, name => name.StartsWith("d"));
        Console.WriteLine("the names  starts with d are" + results1);//system. string[]

        
        bool exists = names.Contains("diana");
        Console.WriteLine(exists);//true 

        //to find duplicates in my array

        int[] id= { 3, 1, 4, 7, 8, 9, 9, 1 };
        int[] unique=id.Distinct().ToArray();
        foreach(int ids in unique)
        {
            Console.WriteLine($" The unique values in my list are{ ids}" + ""); 
        }
        //to count the duplicates values in my string
        string[] animals = { "Cat", "Dog", "Cat", "Elephant" };
        int catCount = animals.Count(a => a == "Cat");

        Console.WriteLine("Number of Cats: " + catCount);  // Output: 2


       



    }
}

