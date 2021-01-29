using System;
using System.Collections.Generic;
using System.Linq;

namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        public static string DestinationInp { get; set; }

        public static int NumberTrainInp { get; set; }

        public static DateTime DateStartInp { get; set; }

        public static List<Train> Trains { get; set; } = new List<Train>();

        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                UserInput();
                var train = new Train(DestinationInp, NumberTrainInp, DateStartInp);
                Train.AddToList(train, Trains);
            }
            Train.GetInfo(Train.SortTrains(Trains).ToList());
            GetTrainNumber();
        }

        public static void UserInput()
        {
            Console.WriteLine();
            Console.Write("Destination: ");
            DestinationInp = Console.ReadLine();

            Console.Write("Number train: ");
            NumberTrainInp = int.Parse(Console.ReadLine());

            Console.Write("Data start: ");
            DateStartInp = DateTime.Parse(Console.ReadLine());
        }

        public static void GetTrainNumber()
        {
            Console.WriteLine();
            Console.Write("Train number: ");
            int userInp = int.Parse(Console.ReadLine());
            Train.SelectNumberTrain(Trains, userInp);

        }
    }
}
