using System;

namespace C__Exam12
{
    class Program
    {
        const int N = 100;
        static void Main(string[] args)
        {
            long s = 0;
            for (int i = 1; i<= N; ++i) s += i;
            Console.WriteLine(s);
        }
    }
}
