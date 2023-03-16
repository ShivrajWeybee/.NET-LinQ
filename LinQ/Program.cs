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
            // Get Emloyees
            var listOfEmps = Employes.GetStudents();

            // Emps whose salary is between 600 - 8000
            var result = listOfEmps.Where(emp => emp.Salary >= 6000 && emp.Salary <= 8000);

            //
            foreach(var em in result)
            {
                Console.WriteLine($"ID : {em.Id}  Name : {em.Name}  Salary : {em.Salary}");
            }

            Console.ReadLine();
        }
    }
}
