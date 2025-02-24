using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo13
{
    public struct Point // Struct sao tipos valores
    {
        public int X { get; set; }
        public int Y { get; set; }  

        public Point(int x, int y) : this() { X = x; Y = y; }
    }
}
