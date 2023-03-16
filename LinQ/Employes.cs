using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Employes : IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static List<Employes> GetStudents()
        {
            return new List<Employes>()
            {
                new Employes { Id = 1001, Name = "Preety", Salary = 5000 },
                new Employes { Id = 1002, Name = "Snurag", Salary = 7000 },
                new Employes { Id = 1003, Name = "Pranaya", Salary = 6500 },
                new Employes { Id = 1004, Name = "Anurag", Salary = 10000 },
                new Employes { Id = 1005, Name = "Hina", Salary = 25000 },
                new Employes { Id = 1006, Name = "Priyanka", Salary = 5500 },
                new Employes { Id = 1007, Name = "santosh", Salary = 6000 },
                new Employes { Id = 1008, Name = "Tina", Salary = 60000 },
                new Employes { Id = 1009, Name = "Celina", Salary = 35000 },
                new Employes { Id = 1010, Name = "Sambit", Salary = 8000 }
            };
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
