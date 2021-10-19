using System;

namespace CalculatingAmountDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of the deposit: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the number of months: ");
            int months = Convert.ToInt32(Console.ReadLine());

            decimal percent = 0.07m;

            /*
            for(int i = 0; i < months; i++)
            {
                sum += sum * percent;
            }
            */

            int i = months;
            while (i >= 1)
            {
                sum += sum * percent;
                i--;
            }

            Console.Write($"The final amount of the deposit: {sum}");

            Console.ReadKey();
        }
    }
}
