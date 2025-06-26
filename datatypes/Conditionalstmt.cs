using System;
using System.Xml.Schema;



class Conditionalstmt
{
    static void Main()
    {
        //using while--execute only the condition is true
        string password = "";
        while (password != "narmada")//till suceess the loop repeats
        {
            Console.WriteLine("enter your  password");
            password = Console.ReadLine();
        }
        Console.WriteLine("login success");
        Console.WriteLine("....................................................");
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine("Number: " + i);//loops continously infinity so we need to increment i
            i++;

        }
        Console.WriteLine(".........using do while...........................................");
        //do while----executes the block atleast once even if the condition is true..

        var j = 10;
        do
        {
            Console.WriteLine(j);
            j--;
        } while (j > 0);//reverese order

        Console.WriteLine(".........using for each...........................................");
        string[] courses = { "full stack", "powerbi", "devops", "testing" };

        foreach(string course in courses)
        {
            Console.WriteLine("the courses are"+course);
            if(course== "full stack")
            {
                int enrolled = 10;
                Console.WriteLine("students entrolled for this fullstack course are" + enrolled);
            }
            else if (course == "powerbi")
            {
                string name  = "narmada";
                int price = 10000;
                Console.WriteLine($"{name } enrolled for this course with price {price}" );
            }
            else if (course == "devops")
            {
                Console.WriteLine("ypu enrolled for devops");
            }
            else if (course == "testing")
            {
                string[] testtypes = { "manual", "selinum", "automation" };
                Console.WriteLine(testtypes);//system.string[]
            }
            else
            {
                Console.WriteLine("please make it fast..classes are ready to begin");
            }
        }
        Console.WriteLine("...........using dowhile realtime .......................");
   
        {
            string userMessage;

            Console.WriteLine("🤖 Chatbot: Hello! Type something and I'll echo it. Type 'bye' to exit.\n");

            do
            {
                Console.Write("say some thing: ");
                userMessage = Console.ReadLine();

                if (userMessage.ToLower() != "bye")
                {
                    Console.WriteLine("🤖 Chatbot: You said \"" + userMessage + "\"");
                }

            } while (userMessage.ToLower() != "bye");

            Console.WriteLine("🤖 Chatbot: Goodbye. Have a good day!");
        }
        Console.WriteLine(".......USING FOR LOOP");
        {
            Console.WriteLine("factorial of number");
            for(int num=1;num<=5;num++)
            {
                int factorial = 1;
                for(int k = 1;k<=num;k++)
                {
                    factorial = factorial * k;
                }
                Console.WriteLine($"{num}! = {factorial}");

            }
        }
    }
}



