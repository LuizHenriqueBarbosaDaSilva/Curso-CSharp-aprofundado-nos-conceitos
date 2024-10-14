using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
    public class HotelExemplo
    {
        public string _Nome {  get; set; }
        public string _Email { get; set; }
        public int _Room { get; set; }
        public HotelExemplo() { }
        public HotelExemplo(string nome,string email, int room)
        {
            _Nome = nome;
            _Email = email;
            _Room = room;
        }


    }
}
