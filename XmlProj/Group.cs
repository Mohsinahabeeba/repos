using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlProj
{
  public class Employee

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Gender { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
                {
                   new Employee { Id=11,Name="john",Dept="HR",Gender="male"},
                   new Employee { Id=11,Name="jack",Dept="IT",Gender="male"},
                   new Employee { Id=11,Name="jill",Dept="HR",Gender="female"},
                   new Employee { Id=11,Name="mary",Dept="IT",Gender="female"},
                    new Employee { Id=11,Name="rosie",Dept="IT",Gender="female"},
                    new Employee { Id=11,Name="rony",Dept="HR",Gender="male"},
                    new Employee { Id=11,Name="raj",Dept="HR",Gender="male"},
                    new Employee { Id=11,Name="rohit",Dept="IT",Gender="male"},
                    new Employee { Id=11,Name="rohini",Dept="HR",Gender="female"},

            };
        }
    }
}
