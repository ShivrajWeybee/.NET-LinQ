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

            //
            var empList = Employes.GetStudents();
            var deptList = Department.GetDepartments();

            //
            Department findDeptId;
            
            try
            {
                //
                Console.WriteLine("Enter department name");
                var deptName = Console.ReadLine();

                findDeptId = deptList.Where(d => d.Name.Contains(deptName)).ToList().Single();
                var result = empList.Where(x => x.DeptId == findDeptId.Id);

                foreach (var a in result)
                {
                    //Console.WriteLine($"Id : {a.Id}  Name : {a.Name}  Salary : {a.Salary}  DeptName : {deptList.Where(n => n.Id == a.DeptId).ToList().ElementAt(0).Name}");
                    Console.WriteLine($"Id : {a.Id}  Name : {a.Name}  Salary : {a.Salary}  DeptName : {deptName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
