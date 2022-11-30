using System;

namespace Hello_World_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            STAThreadAttribute();
            
        }
        private static void STAThreadAttribute();
        {
            Console.WriteLine("\nWhat is your Name?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.Write($"\nHello, {name}, on {date:d} at {date:t}");
            Console.Write("\nPress any key to exit... ");
            return = 0;
        }
    }
}
