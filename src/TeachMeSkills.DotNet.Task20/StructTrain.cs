using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachMeSkills.DotNet.Task20
{
    public struct Train
    {
        public Train(string destination, int numberTrain, DateTime dateTimeStart )
        {
            _destination = destination;
            _numberTrain = numberTrain;
            _dateTimeStart = dateTimeStart;
        }

        private string _destination;
        private int _numberTrain;
        private DateTime _dateTimeStart;

        public static List<Train> AddToList(Train train, List<Train> trains )
        {
            trains.Add(new Train
            {
                _numberTrain = train._numberTrain,
                _dateTimeStart = train._dateTimeStart,
                _destination = train._destination
            });
            return trains;
        }

        public static void SelectNumberTrain(List<Train> trains, int userInpNumber)
        {
            foreach (var item in trains)
            {
                if (item._numberTrain == userInpNumber)
                {
                    List<Train> selectTrain = new List<Train> { item };
                    Console.ForegroundColor = ConsoleColor.Green;
                    GetInfo(selectTrain);
                    Console.ResetColor();
                }
                if (item._numberTrain != userInpNumber)
                {
                    Console.WriteLine("Select train is availeble");
                }
            }
        }

        public static IList<Train> SortTrains(List<Train> trains)
        {
            return trains.OrderBy(x => x._numberTrain).ToList();
        }

        public static void GetInfo(List<Train> trains)
        {
            foreach (var item in trains)
            {
                Console.WriteLine("");
                Console.WriteLine($"Destination: {item._destination}");
                Console.WriteLine($"Number train: {item._numberTrain}");
                Console.WriteLine($"Time start: {item._dateTimeStart}");
            }
        }
    }
}
