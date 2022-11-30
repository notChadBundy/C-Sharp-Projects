using System;

namespace C__Exam13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day number in week:");
            string text = Console.ReadLine();
            switch (Convert.ToInt32(text))
            {
                case 1:
                Console.WriteLine("Monday");
                break;

                case 2:
                Console.WriteLine("Tuesday");
                break;

                case 3:
                Console.WriteLine("Wednesday");
                break;

                case 4:
                Console.WriteLine("Thursday");
                break;

                case 5:
                Console.WriteLine("Friday");
                break;

                case 6:

                case 7:
                Console.WriteLine("Weekend");
                break;

                default:
                Console.WriteLine("Invalid Day");
                break;
            }
        }
    }
}
