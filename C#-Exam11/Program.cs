using System;

namespace C__Exam11
{
    class Program
    {
        const int N = 100;
        static void Main(string[] args)
        {
           long s = 0;
           int n = 1;
           while (n <= N)
           {s += n;
            ++n;
            }
            Console.WriteLine(s);
        }
    }
}
