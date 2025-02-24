using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo13
{
    public class ProductServ
    {
        public string Name { get; set; }
        public decimal Price { get; set; }  

        public ProductServ(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode(); 
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is ProductServ)) { return false; }

            ProductServ other = obj as ProductServ;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
