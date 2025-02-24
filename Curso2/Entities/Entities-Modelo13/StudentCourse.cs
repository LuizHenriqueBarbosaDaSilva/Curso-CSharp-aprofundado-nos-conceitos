using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo13
{
    public class StudentCourse
    {
        public int StudentId { get; set; }

        public override int GetHashCode()
        {
            return StudentId.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is StudentCourse)) { return false; } 
            
            StudentCourse other = (StudentCourse)obj;
            return StudentId.Equals(other.StudentId);
        }


    }
}