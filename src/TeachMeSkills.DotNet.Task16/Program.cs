using System;
using System.Threading;
using System.Threading.Tasks;

namespace TeachMeSkills.DotNet.Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            GetName();
        }

        public static async void GetName()
        {
            await Name();
        }

        public static async Task Name()
        {
            Console.WriteLine("Start get name!");
            Thread.Sleep(2000);
            Console.WriteLine("Stop get na,e");
        }
    }
}
