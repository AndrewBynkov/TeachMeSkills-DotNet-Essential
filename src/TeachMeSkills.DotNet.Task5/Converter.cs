using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task5
{
    class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _rub = rub;
            _eur = eur;
        }

        private double _usd;
        private double _eur;
        private double _rub;

        public double SumOfCurrency { get; set; }

        public void CurrencyConvert()
        {
            Console.WriteLine($"BYN to USD: {SumOfCurrency / _usd}");
            Console.WriteLine($"BYN to EUR: {SumOfCurrency / _eur}");
            Console.WriteLine($"BYN to RUB: {SumOfCurrency / _rub}");
        }
    }
}
