using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] argds)
        {
            int num, deno;

            Console.WriteLine("Enter 1--> ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2 --> ");
            deno = int.Parse(Console.ReadLine());


            int quotient = num / deno;
            int reminder = num % deno;

            Console.WriteLine($"Quotient --> {quotient} , Reminder --> {reminder}");

            double fra_quotient = Math.Round((double)num / deno);

            Console.WriteLine($"Fractional Qoutient --> {fra_quotient}");
            Console.WriteLine($"Mixes Fraction --> {quotient} {reminder}/{deno}");
        }
    }
}
