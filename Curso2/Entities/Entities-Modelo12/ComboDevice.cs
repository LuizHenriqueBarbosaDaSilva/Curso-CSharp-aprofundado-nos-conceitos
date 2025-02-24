using Curso2.Entities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo12
{
    class ComboDevice : Device,IScanner,IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }
    }
}
