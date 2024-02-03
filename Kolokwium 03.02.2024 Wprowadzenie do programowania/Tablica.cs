using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_03._02._2024_Wprowadzenie_do_programowania
{
    internal static class Tablica
    {
        public static string[] ReverseStringTable(String[] StringTable)
        {
            List<string> StringList = new List<string>(StringTable);

            StringList.Reverse();

            StringList.CopyTo(StringTable);

            return StringTable;
        }

        public static int[] ReverseIntTable(int[] ints)
        {
            List<int> ints1 = new List<int>(ints);

            ints1.Reverse();

            ints1.CopyTo(ints);

            return ints;
        }
    }
}
