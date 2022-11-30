using System;

namespace C__SeventhApplet
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime dt = DateTime.Now;
           DateTime dx = DateTime.Now;
           Time1(dt);
           Time2(dx);//Console.WriteLine("Hello World!");
        }

        private static void Time1(DateTime dt)
                {
            Console.WriteLine(("{0:D2} {1:D2} {2:D2} {3:D2}"), t.Hours , t.Minute, t.Second, t.Milliseconds);
        }

        private static void Time2 (DateTime dx);
        {
            Console.WriteLine(t.ToLongDateString());
            Console.WriteLine(t.ToLongTimeString());
        }
    }
}
