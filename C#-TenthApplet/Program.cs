using System;

namespace C__TenthApplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            string first;
            string second;
            string final;
            Console(WriteLine("Enter the first variable"));
            first = ReadLine();
            x = Console(ConvertToInt(first));
            Console(WriteLine("Enter the second variable"));
            second = Console(ReadLine());
            y = Console(ConvertToInt(second));
            z = x + y;
            final = Console(ConvertToString(z));
            Console(WriteLine(final));//Console.WriteLine("Hello World!");
        }
    }
}
