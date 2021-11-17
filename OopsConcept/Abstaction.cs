using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Abstaction
{
        abstract class Fruit
        {
            // Abstract method (does not have a body)
            public abstract void fruitTest();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Healthy");
            }
        }

        // Derived class (inherit from Fruit)
        class Apple : Fruit
        {
            public override void fruitTest()
            {
                
                Console.WriteLine("Apple is Sweet");
            }
        }


    
}
