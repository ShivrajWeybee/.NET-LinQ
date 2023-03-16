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
            string[] files =
            {
                "file1.txt",
                "file2.pdf",
                "file3.xml",
                "file4.txt",
                "file5.pdf"
            };

            var result = files.Where(x => x.Contains(".txt"));

            Console.WriteLine($"Total - {result.Count()}");
            foreach (var a in result)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
