using System;

namespace C__FifthApplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unit Price: ");
            string text = Console.ReadLine();
            double price = Convert.ToDouble(text);
            Console.Write("Enter the number of units: ");
            text = Console.ReadLine();
            double quantity = Convert.ToDouble(text); //
            double amount = price * quantity;
            double vat = amount * 0.25;//
            double total = amount +vat;
            Console.WriteLine("{0, -15} {1, 10:F}", "Unit Price", price);
            Console.WriteLine("{0, -15} {1, 10:D}", "Number of units", quantity);
            Console.WriteLine("{0, -15} {1, 10:F}", "Total excl. vat", quantity);
            Console.WriteLine("{0, -15} {1, 10:F}", "VAT", vat);
            Console.WriteLine("{0, -15} {1, 10:F}", "Total incl.Vat", total);
        }
    }
}
