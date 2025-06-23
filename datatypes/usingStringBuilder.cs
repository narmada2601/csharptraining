using System;
using System.Text;
class usingStringBuilder
    {
    static void Main()
    {
        //building strings over other strings
        int jumpCount = 10;
        string[] animals= { "GOATS", "CATS", "LIONS" };
        //create a  string builder
        StringBuilder sb = new StringBuilder("Intial string", 200);
        Console.WriteLine($"capacity:{sb.Capacity}; length:{sb.Length}");//capacity:200 length:13

        //adding some strings to the builder using append

        sb.Append("little red riddinghood was a young girl.");
        sb.Append("one day her mother asked her to take basket of food to her grandmaa!");

        //appendLine can append line ending
        sb.AppendLine();

        //appendformat can be used to append the formating strings
        sb.AppendFormat("he did high jumps {0}" ,jumpCount);
        sb.AppendLine();
        //itterate set of values
        sb.Append("he jumps");
        
        //modify
        sb.Replace("CATS","FOX");

        //INSERT content at the index
        sb.Insert(0, "Red Ridding hood");

        //convert to a single string
        Console.WriteLine(sb.ToString());
    }
    }

