using System;

namespace Codevelp
{
    public class Initila : object 
    {
        internal static void Main (string[] Arguments)
        {
            Console.Write("Hello!");
            Console.ReadLine();
            Console.Write("What's your name?: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("What's your age old?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hello {0}, your age old is {1}. nice to meet you...", name, age);
            Console.ReadLine();
            Console.WriteLine("Goodbye {0}", name);
            Console.Read();
        }
    }
}