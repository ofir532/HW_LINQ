using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> selectedNumbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Select(selectedNumbers);
            Console.WriteLine();
            List<string> selectedStrings = new List<string>() { "abc", "DBe", "Eaax1", "X5a", "BCD", "cgj" };
            Where(selectedStrings);
        }
        static void Select(List<int> list)
        {
            foreach (var num in list)
            {
                Console.Write(num + ", ");
            }
        }

        static void Where(List<string> list)
        {

            foreach (var str in list)
            {
                if (str.Length > 4)
                Console.WriteLine(str);
            }

        }
    }
}
