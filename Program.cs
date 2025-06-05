using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var day in Enum.GetValues(typeof(DaysWeek)))
            {
                Console.WriteLine($"{day} имеет значение {(int)day}");
            }
        }
    }
}
