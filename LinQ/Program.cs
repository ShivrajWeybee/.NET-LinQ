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
            var empList = Employes.GetStudents();
            var deptList = Department.GetDepartments();

            // ----------------------------------------------------------------------------------------------------------

            Department findDeptId;

            try
            {
                //var deptName = Console.ReadLine();
                //do
                //{                 
                //    Console.WriteLine("Enter department name");
                //    deptName = Console.ReadLine();
                //}
                //while (deptList.Select(x => x.Name).ToList().Contains(deptName)) ;

                Console.WriteLine("Enter department name");
                var deptName = Console.ReadLine();

                findDeptId = deptList.Where(d => d.Name == deptName).First();
                var result = empList.Where(x => x.DeptId == findDeptId.Id);

                foreach (var a in result)
                {
                    Console.WriteLine($"Id : {a.Id}  Name : {a.Name}  Salary : {a.Salary}  DeptName : {findDeptId.Name}");
                    //Console.WriteLine($"Id : {a.Id}  Name : {a.Name}  Salary : {a.Salary}  DeptName : {deptName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


            // ----------------------------------------------------------------------------------------------------------


            //var resultQS = from emp in empList
            //               join dept in deptList
            //               on emp.DeptId equals 
            //               select new
            //               {

            //               };


            Console.ReadLine();
        }
    }
}
