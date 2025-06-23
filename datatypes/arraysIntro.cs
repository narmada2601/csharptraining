using System;
     class arraysIntro
    {
    static void Main()
    {
        string[] student = new string[3];//this array store 3 values 0,1,2, should be in sorting order
        student[0] = "narmada";
        student[1] = "Likhil";
        student[2] = "aravind";
        string studentNames = string.Format("studentname:{0} studentname:{1}studentname{2}", student[0], student[1], student[2]);
        Console.WriteLine(studentNames);
        //we can also declare
        //string[] childrens = new string[3] { "isha", "reha", "kittu" };
        //Console.WriteLine("childrens are"+childrens);

        //Console.WriteLine(childrens[0]);//isha
        //Console.WriteLine(childrens[2]);//kittu
        //Console.WriteLine(childrens[3]);//index out of range exception
        //                                //another way to declare
        
        string[] cities = { "mumbai","delhi","banglore","hyderbad","jaipur","kanpur" };
        Console.WriteLine("cities in the array list");
        for (int i = 0; i < cities.Length; i++)
            Console.Write(cities[i] + "     ");

        Console.WriteLine("\n\nChaging the Elements of the Array...");
        cities[2] = "visakapatanam";
        cities[4] = "buvaneswar";

        Console.WriteLine("\n---New Array after Change---");
        for (int i = 0; i < cities.Length; i++)
            Console.Write(cities[i] + "     ");
        //foreach (string x in cities)
        //    Console.WriteLine(x);
    }
}

