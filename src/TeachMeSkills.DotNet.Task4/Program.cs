using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var addres = new Address(220228, "Belarus", "Minsk", "Kosmonavtov", "6", "74");
            Console.WriteLine($"Index - {addres.Index}\n" +
                $"Country - {addres.Country}\n" +
                $"City - {addres.City}\n" +
                $"Street - {addres.Street}\n" +
                $"House - {addres.House}\n" +
                $"Appartment - {addres.Apartment}");
        }
    }
}
