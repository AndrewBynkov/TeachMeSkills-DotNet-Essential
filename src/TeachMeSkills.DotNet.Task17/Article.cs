using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Article> GetInfoNameProduct(Article[] article, string nameOfProduct)
        {
            return article.Where(x => x._productName == nameOfProduct).ToList();
        }
    }
}
