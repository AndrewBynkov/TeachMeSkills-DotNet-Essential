using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task22
{
    public struct StructNotebook
    {
        public StructNotebook(string model, string produced, int price)
        {
            Model = model;
            Produced = produced;
            Price = price;
        }

        public string Model { get; set; }
        public string Produced { get; set; }
        public decimal Price { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Model - {Model}, Produced - {Produced}, Price - {Price}");
        }
    }
}
