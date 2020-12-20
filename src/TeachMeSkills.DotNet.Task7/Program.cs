using System;

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice(193342360,"LLC AMAZON", "LLC AlphaStyle", "Computer");

            (decimal withVAT, decimal withoutVAT) = invoice.GetOrderCost(2, 115);
            invoice.GetInfo(withVAT, withoutVAT);
        }
    }
}
