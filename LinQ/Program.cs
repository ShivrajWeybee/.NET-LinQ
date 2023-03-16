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
            List<string> names = new List<string> { "Om", "Mark", "Dustiban", "Rancho", "Haranika", "Mes", "Darsahn", "Brandan", "Brandie", "Tony", "A", "Rancho", "Darsahn" };

            // name whose length is 4 or 4 +
            var result = names.Where(n => n.Length >= 4);
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //name whose length is 4 or 4 
            var result2 = names.Where(n => n.Length == 4);
            foreach (var name in result2)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
