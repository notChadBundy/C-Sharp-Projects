using System;

namespace C__EleventhApplet
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Enter("Enter a");
            double b = Enter("Enter b");
            double c = Enter("Enter c");
            Solve(a, b, c);
        }

        static double Enter (string text)
        {
            Console.Write(text + ": ");
            string line = Console.ReadLine();
            return Convert.ToDouble(line);
        }

        static void Solve(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            Console.WriteLine("The Equation {0:F4}x^2 + {1:F4}x + {2:F4} = 0", a, b, c);
            if (d < 0) Result();
            else if(d > 0) Result(a, b, d);
            else Result(a, b);
        }    

        static void Result()
        {
            Console.WriteLine("has no solution");
        }

        static void Result (double a, double b)
        {
            Console.WriteLine("has Solution {0:F4}", -b / (2 * a));
        }

        static void Result(double a, double b, double d)
        {
            double y = Math.Sqrt(d);
            Console.WriteLine("has Solutions {0:F4} and {1:F4}",
            (-b -y) / (2 * a), (-b +y) / (2 * a));
        }
    }

}
