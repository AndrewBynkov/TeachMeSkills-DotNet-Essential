using System;

namespace TeachMeSkills.DotNet.Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date of you bithday: ");
            var dateBithday = DateTime.Parse(Console.ReadLine());

            int day = dateBithday.Day;
            int month = dateBithday.Month;
            int year = DateTime.Now.Year;
            var dateTimeNow = DateTime.Now.Date;

            DateTime dateBithDayNowYear = new DateTime(year, month, day);
            Console.WriteLine(dateBithDayNowYear.Subtract(dateTimeNow));
        }
    }
}
