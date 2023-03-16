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
            List<string> names1 = new List<string> { "Mark", "Dustiban", "Rancho", "Haranika", "Darsahn", "Brandan", "Brandie", "Mark", "Rancho", "Darsahn" };
            List<string> names2 = new List<string> { "Smith", "Marcus", "David", "Nathon" };

            // merge 2 list
            var result = names1.Concat(names2);

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }


            Console.ReadLine();
        }
    }
}
