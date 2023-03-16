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

            // Get name which contains substring of "ran"
            string searchString = "ran";
            var result = names.Where(x => x.ToLower().Contains(searchString));


            //
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
