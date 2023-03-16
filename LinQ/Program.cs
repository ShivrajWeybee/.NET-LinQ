using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names1 = new List<string> { "Mark", "Dustiban", "Rancho", "Yastika", "Haranika", "Darsahn", "Yo-Yo", "Brandan", "Brandie", "Xerox", "Mark", "Rancho", "Darsahn", "X-men" };

            // get element from 5th index to next 5 element in list
            var result1 = names1.Skip(5).TakeWhile(x => x != names1.ElementAt(10));

            foreach (var a in result1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            // get element which starts with "X"
            IEnumerable<string> result2 = names1.Where(x => x.StartsWith("X"));

            foreach (string a in result2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            // get element which starts with "y"
            var result3 = names1.Where(x => x.StartsWith("Y"));

            foreach (string a in result3)
            {
                Console.WriteLine(a);
            }
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
