using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo13
{
    public class ClientCustom
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is ClientCustom))
            {
                return false;
            } 
            ClientCustom other = obj as ClientCustom;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode() {  return Email.GetHashCode(); } 
    }
}
