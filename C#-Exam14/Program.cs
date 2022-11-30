using System;

namespace C__Exam14
{
    class Program
    {
        static void Main(string[] args)
        {
         ulong number = Enter();
         Console.Writeline("The reduced sum of digits in {0} is {1}", number, DigitSum(number));
        }

        static uint DigitSum(int n)
        {
            while (n > 9)
            {
                ulong s = 0;
                while (n > 0)
                {
                    s += n % 10;
                    n/= 10;
                }
                n = s;
            }
            return (uint)n;
        }
    }
}

