﻿using Curso2.Entities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo12
{ 
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: "+ document);
        }

        public void Print(string document) 
        {
            Console.WriteLine("Printer print "+ document);
        }

    }
}
