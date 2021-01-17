using System;

namespace TeachMeSkills.DotNet.Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = GetArray().SortArrays();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] GetArray()
        {
            int[] arrayNums = new int[10];

            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = new Random().Next(50);
            }
            return arrayNums;
        }
    }
}
