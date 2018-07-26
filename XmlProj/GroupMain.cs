using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlProj
{
    class GroupMain
    {
        public static void Main()
        {
            var EmpGroups = from Emp in Employee.GetAllEmployees()
                            group Emp by Emp.Dept;
            foreach(var group in EmpGroups)
            {
                Console.WriteLine("{0}-{1}", group.Key, group.Count(x=>x.Gender = "male"));
            }
        }
    }
}
