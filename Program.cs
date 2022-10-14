using System;
using Codevelp;

namespace Codevelp
{
    public class Initial : object 
    {
        public void Questions ()
        {
            Console.Write("Hello!");
            Console.ReadLine();
            Console.Write("What's your name?: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("What's your age old?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hello {0}, your age old is {1}. nice to meet you...", name, age);
            Console.ReadLine();
            Console.WriteLine("Goodbye {0}", name);
            Console.Read();

        }
        internal static void Main (string[] Arguments)
        {
            Initial start = new Initial();
            start.Questions();
        }
    }
}