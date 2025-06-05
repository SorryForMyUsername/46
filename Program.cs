using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var month in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine($"{(int)month}\t{month}");
            }

            Console.ReadKey(true);
        }
    }
}
