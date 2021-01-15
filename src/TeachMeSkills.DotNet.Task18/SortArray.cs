using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachMeSkills.DotNet.Task18
{
    public static class SortArray
    {
        public static int[] SortArrays(this int[] arrayNum)
        {
            return arrayNum.OrderBy(x => x).ToArray();
        }
    }
}
