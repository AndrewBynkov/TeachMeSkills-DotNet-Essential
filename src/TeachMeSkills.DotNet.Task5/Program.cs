using System;

namespace TeachMeSkills.DotNet.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter sum of currency BYN: ");
            double sumOfCurrency = default;

            bool canParce;
            do
            {
                canParce =  double.TryParse(Console.ReadLine(), out double val1);
                sumOfCurrency = val1;
            }
            while (!canParce);

            var Converter = new Converter(2.561, 3.038, 0.0334)
            {
                SumOfCurrency = sumOfCurrency
            };

            Converter.CurrencyConvert();
        }
    }
}
