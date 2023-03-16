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
            List<string> names = new List<string> { "Mark", "Dustiban", "Rancho", "Haranika", "Darsahn", "Brandan", "Brandie" };

            // reverse the list of names
            //names.Reverse();

            IEnumerable<string> result = names.AsEnumerable().Reverse();

            // printing
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
