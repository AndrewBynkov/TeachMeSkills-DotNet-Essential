using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task9
{
    public class Pupil
    {

        public Pupil(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        public List<string> Pupils { get; set; } = new List<string>() { "John Dilinger", "Andrew Bynkov","Mikulich Kristina", "Roman Hisak", "Roman Zalatar" };

        public void Study()
        {

        }

        public void Read()
        {

        }

        public void Write()
        {

        }

        public void Relax()
        {

        }
    }

    public class ExcelentPupil : Pupil
    {

    }

    public class GoodPupil : Pupil
    {

    }

    public class BadPupil : Pupil
    {

    }
}
