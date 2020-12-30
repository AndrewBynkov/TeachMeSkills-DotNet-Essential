using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task17
{
    public class Article
    {
        public Article(string prodName, string shopName, decimal Price )
        {
            _productName = prodName;
            _productPrice = Price;
            _shopName = shopName;
        }

        private string _productName;

        private string _shopName;

        private decimal _productPrice;

        public void GetInfoProduct()
        {
            Console.WriteLine($"Product name: {_productName}");
            Console.WriteLine($"Shop name: {_shopName}");
            Console.WriteLine($"Product price: {_productPrice}");
        }

        public void GetInfoNameproduct(string name)
        {
            if (_productName == name)
            {
                Console.WriteLine($"Product name: {_productName}");
                Console.WriteLine($"Shop name: {_shopName}");
                Console.WriteLine($"Product price: {_productPrice}");
            }
        }
    }
}
