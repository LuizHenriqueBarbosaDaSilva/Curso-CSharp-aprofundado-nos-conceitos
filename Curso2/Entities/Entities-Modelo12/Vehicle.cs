using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Model12
{
    public class Vehicle
    {
        public string Model { get; set; }
        public Vehicle(string model)
        {
            Model = model;

        }
    }
}