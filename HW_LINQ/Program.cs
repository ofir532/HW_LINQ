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
        }
        static void Select(List<int> list)
        {
            foreach (var num in list)
            {
                Console.Write(num + ", ");
            }
        }

        static void Where()
        {

        }
    }
}
