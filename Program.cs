using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_found
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 4, 5 };
            Console.Write("enter:");
            int.TryParse(Console.ReadLine(), out int  search);
            int found = Array.BinarySearch(array, search);
            Console.WriteLine($"found={found}");
             Console.WriteLine($"found={found}");
          
            Console.ReadKey();
        }
    }
}
