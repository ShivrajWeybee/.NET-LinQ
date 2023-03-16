using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Employes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DeptId { get; set; }

        public static List<Employes> GetStudents()
        {
            return new List<Employes>()
            {
                new Employes { Id = 1001, Name = "Preety", Salary = 5000, DeptId = 2005 },
                new Employes { Id = 1002, Name = "Snurag", Salary = 7000, DeptId = 2001 },
                new Employes { Id = 1003, Name = "Pranaya", Salary = 6500, DeptId = 2003 },
                new Employes { Id = 1004, Name = "Anurag", Salary = 10000, DeptId = 2002 },
                new Employes { Id = 1005, Name = "Hina", Salary = 25000, DeptId = 2002 },
                new Employes { Id = 1006, Name = "Priyanka", Salary = 5500, DeptId = 2005 },
                new Employes { Id = 1007, Name = "santosh", Salary = 6000, DeptId = 2004 },
                new Employes { Id = 1008, Name = "Tina", Salary = 60000, DeptId = 2002 },
                new Employes { Id = 1009, Name = "Celina", Salary = 35000, DeptId = 2001 },
                new Employes { Id = 1010, Name = "Sambit", Salary = 8000, DeptId = 2003 }
            };
        }
    }
}
