using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo12
{
    abstract class Device
    {
        public int SerialNumber {  get; set; }

        public abstract void ProcessDoc(string document);
    }
}
