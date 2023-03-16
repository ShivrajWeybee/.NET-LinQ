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
            List<string> names = new List<string> { "Mark", "Dustiban", "Rancho", "Haranika", "Darsahn", "Brandan", "Brandie", "Mark", "Rancho", "Darsahn" };

            // get first 3 element from list
            var result = names.Take(3);

            //
            foreach(var a in result)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
