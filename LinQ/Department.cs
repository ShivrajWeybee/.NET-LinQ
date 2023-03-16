using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Department
    {
        public int Id;
        public int GetId(string deptName)
        {
            //var tempId = 
            return Id;
        }
        public string Name { get; set; }

        public static List<Department> GetDepartments()
        {
            return new List<Department>()
            {
                new Department { Id = 2001, Name = "Administration" },
                new Department { Id = 2002, Name = "Research and development" },
                new Department { Id = 2003, Name = "Marketing and sales" },
                new Department { Id = 2004, Name = "Human resources" },
                new Department { Id = 2005, Name = "Accounting and finance" }
            };
        }
    }
}
