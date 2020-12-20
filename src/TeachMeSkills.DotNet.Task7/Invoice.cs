using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task7
{
    public class Invoice
    {
        public Invoice(int account, string customer, string provider, string article)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
            _article = article;
        }


        private readonly int _account;

        private readonly string _customer;

        private readonly string _provider;

        private readonly string _article;

        private int _quantity;

        private decimal _cost;


        internal (decimal, decimal) GetOrderCost(int quantity, decimal cost)
        {
            _quantity = quantity;
            _cost = cost;

            var orderValueWithVAT = _quantity * _cost * 1.2M;
            var orderValueWithoutVAT = _quantity * _cost;

            return (orderValueWithVAT, orderValueWithoutVAT);
        }

        internal void GetInfo(decimal withVAT, decimal withoutVAT)
        {
            Console.WriteLine($"Account - {_account}\n" +
                $"Customer - {_customer}\n" +
                $"Provider - {_provider}\n" +
                $"Article - {_article}\n" +
                $"Quantity - {_quantity}\n" +
                $"Cost - {_cost}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nOrder Value With VAT - {withVAT}\n" +
                $"Order Value Without VAT - {withoutVAT}");
            Console.ResetColor();

        }
    }
}
