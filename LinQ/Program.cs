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

            // get element from 5th index to next 5 element in list
            var result = names.Skip(4).Take(5);

            //
            foreach(var a in result)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
