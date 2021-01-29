using System;

namespace TeachMeSkills.DotNet.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.change = "не изменено";
            ClassTaker(myClass);

            var stract = new MyStruct();
            stract.change = "не изменено";
            StruktTaker(stract);

            Console.WriteLine(myClass.change);
            Console.WriteLine(stract.change);
        }

        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        public static void StruktTaker(MyStruct stract)
        {
            stract.change = "Изменено";
        }
    }
}
