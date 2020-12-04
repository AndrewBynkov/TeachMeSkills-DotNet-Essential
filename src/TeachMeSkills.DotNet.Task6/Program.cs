using System;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var employer1 = new Employee("Andrew", "Bynkov");
            var employer2 = new Employee("Kristina", "Mikulich");
            var employer3 = new Employee("Roman", "Hisak");

            employer1.GetSalaryAndEmployerInfo();
            employer2.GetSalaryAndEmployerInfo();
            employer3.GetSalaryAndEmployerInfo();
        }
    }
}
