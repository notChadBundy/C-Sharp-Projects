using System;

namespace C__Exam16
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true)
           {
               string line =Enter();
               if (IsPalindrom(line.ToLower())) Console.WriteLine(line + " Is a palindrom");
               else Console.WriteLine(line + " Is not a palindrom");
           }
        }

        static string Enter()
        {
            Console.Write("? ");
            string text = Console.ReadLine();
            if(text.Length == 0) Environment.Exit(0);
            return text;
        }

        static bool IsPalindrom(string text)
        {
            for (int i = 0, j = text.Length -1; i<j;)
            {
                if (!CharOk(text[i]) && !CharOk(text[j]))
                {
                    ++i;
                    --j;
                }
                else if(!CharOk(text[i]))
                i++;
                else if (!CharOk(text[j]))
                --j;
                else if (text[i] != text[j])
                return false;
                else
                {
                    ++i;
                    --j;
                }
            }
            return true;
        }

        static bool CharOk(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || 
            (ch >= '0' && ch <= '9') || ch == 'æ' || ch == 'Φ' ||//if you get a error check here
            ch == 'å';
        }
    }
}
