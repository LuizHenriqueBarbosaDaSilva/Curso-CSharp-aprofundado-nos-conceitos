using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo15
{
    public class Employee32
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public Employee32(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

       
    }
}
