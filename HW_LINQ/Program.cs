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
            var results_ints0 = selectedNumbers.Select(selectedNumbers => selectedNumbers);
            foreach (var list in results_ints0)
            {
                Console.Write(list + ", ");
            }
            Console.WriteLine();

            List<string> selectedStrings = new List<string>() { "abc", "DBe", "Eaax1", "X5a", "BCD", "cgj" };
            var results_strings0 = selectedStrings.Where(selectedStrings => selectedStrings.Length > 4);
            foreach (var list in results_strings0)
            {
                Console.WriteLine(list + ", ");
            }


            var results_ints1 = selectedNumbers.OrderBy(selectedNumbers => selectedNumbers);
            var results_ints2 = selectedNumbers.OrderByDescending(selectedNumbers => selectedNumbers);
            var results_strings1 = selectedStrings.OrderBy(selectedStrings => selectedStrings);
            var results_strings2 = selectedStrings.OrderByDescending(selectedStrings => selectedStrings);
            foreach (var list in results_ints1)
            {
                Console.Write(list + ", ");
            }
            Console.WriteLine();
            foreach (var list in results_ints2)
            {
                Console.Write(list + ", ");
            }
            Console.WriteLine();
            foreach (var list in results_strings1)
            {
                Console.Write(list + ", ");
            }
            Console.WriteLine();
            foreach (var list in results_strings2)
            {
                Console.Write(list + ", ");
            }
            Console.WriteLine();

        }
    }
}
