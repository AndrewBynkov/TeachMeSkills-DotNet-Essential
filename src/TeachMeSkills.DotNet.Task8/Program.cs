using System;

namespace TeachMeSkills.DotNet.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateNow = DateTime.Now;

            var user = new User(dateNow)
            {
                Login = "AndyDavis",
                FirstName = "Andrew",
                SecondName = "Bynkov",
            };

            user.GetInfo();
        }
    }
}
