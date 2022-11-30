using System;

namespace C__Exam22
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin c1 = new Coin();
            Coin c2  = new Coin();
            do
            {
                c1.Throw();
                c2.Throw();
                z1 = Convert.ToString(c1);
                z2 = Convert.ToString(c2);
                Console.WriteLine(c1.Value + " " + c2.Value);
            }
            while (c1.Value != 'H' || c2.Value != 'H');
        }
                  
        }

    class Coin
        {
            private static Random rand = new Random();
            private char value;

            public Coin()
            {
                Throw();
            }

            public char Value
            {
                get {return Value;}
            }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Throw()
            {
                value = (rand.Next(2) == 0) ? 'H' : 'T';
            }

            public override string ToString()
            {
                return " " + value;
            } 
        }
}
