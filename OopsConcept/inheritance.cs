using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.inheritance
{
     class Vehical
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Bike : Vehical  // derived class (child)
    {
        public string modelName = "KTM";  
    }
}
