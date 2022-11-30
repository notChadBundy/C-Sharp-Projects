using System;

namespace C__FourthApplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how old are you: ");
            string text = Console.ReadLine();
            double r = Convert.ToDouble(text);
            double p = r * 2 * Math.PI;
            double a = r * r * Math.PI;
            Console.WriteLine(" The Perimetre and area of a circle with radius {0:F4}: {1:F4}, {2:F4}", r, p, a);
        }
    }
}
