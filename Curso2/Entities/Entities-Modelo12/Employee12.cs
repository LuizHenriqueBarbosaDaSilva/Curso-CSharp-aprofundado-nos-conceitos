using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo12
{
    public class Employee12 : IComparable
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee12(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = decimal.Parse(vect[1],CultureInfo.InvariantCulture);

        }

        public override string ToString()
        {
            return $"{Name},{Salary.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Object obj)
        {
            if (!(obj is Employee12))
            {
                throw new ArgumentException("Comparing error: argument is an employee12");
            }
            Employee12 other = (Employee12)obj;
            return Name.CompareTo(other.Name);
        }
    }
}
