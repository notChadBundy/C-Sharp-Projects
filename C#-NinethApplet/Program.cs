using System;

namespace C__NinethApplet
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {

            //int text1 = Enter();
            //int text2 = Enter();
            int text1 = 0;
            int text2 = 0;
            NewMethod1(text1);
            NewMethod2(text2);
            NewMethod3(text1, text2);

            static void NewMethod1(int text1)
            {
                Console.WriteLine("Enter another Interger: ");
                string Juice1 = Console.ReadLine();
                text1 = Convert.ToInt32(Juice1);
            }

            static void NewMethod2(int text2)
            {
                Console.WriteLine("Enter another Interger: ");
                string Juice2 = Console.ReadLine();
                text2 = Convert.ToInt32(Juice2);
            }

            static void NewMethod3(int text1, int text2)
            {
                if (text1 <= text2)
                {
                    int XX;
                    XX = text1;
                    text1 = text2;
                    XX = text2;
                    Console.WriteLine("{0} {1}", text1, text2);
                }
                else
                {
                    Console.WriteLine("Try Again Boy");
                }
            }
            //static int First(string[] args, ref string text1, string text2)
            //{
            //}

            //static int Second(string[] args, ref string text1, string text2)
            //{
            //}

            //static void Third(string[] args, ref int Integer1, int Integer2, int text1, int text2)
            //{
            //  if (text1 <= text2)
            //{
            //  int XX = Integer1;
            //Integer1 = Integer2;
            //XX = Integer2;
            //}
            //Console.WriteLine("{0} {1}", Integer1, Integer2);
        }
    }

    class Program : NewBaseType
    {
    }
}

