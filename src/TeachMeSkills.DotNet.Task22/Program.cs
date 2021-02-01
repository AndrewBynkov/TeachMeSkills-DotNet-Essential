using System;

namespace TeachMeSkills.DotNet.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new StructNotebook("BMW", "General Motors", 150000);
            notebook.ShowInfo();
        }
    }
}
