using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo15
{
    public class ProductExercicio
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductExercicio(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
