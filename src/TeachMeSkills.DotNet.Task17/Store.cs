using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachMeSkills.DotNet.Task17
{
    public class Store
    {
        private readonly Article[] article = new Article[2];

        public Article[] AddProducts()
        {
            for (int i = 0; i < article.Length; i++)
            {
                Console.Write("Enter product name: ");
                var name = Console.ReadLine();

                Console.Write("Enter shop name: ");
                var shopName = Console.ReadLine();

                Console.Write("Enter price: ");
                var price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();

                article[i] = new Article(name, shopName, price);
            }
            return article;
        }

        public void GetInfo()
        {
            bool parse;
            int inputIndex;

            do
            {
                Console.Write("Enter index product: ");
                parse = int.TryParse(Console.ReadLine(), out int valueIndex);
                inputIndex = valueIndex;
            }
            while (!parse);

            article.ElementAt(inputIndex).GetInfoProduct();

            Console.WriteLine();
            Console.WriteLine("Enter name product: ");
            var inputName = Console.ReadLine();

            
        }
    }
}
