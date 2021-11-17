using OopsConcept.ClassAndMethodExample;
using OopsConcept.inheritance;
using OopsConcept.polyoverriding;
using OopsConcept.Polyoverloading;
using OopsConcept.Abstaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.ClassAndMethodExample
{
     class Program
    {
        static void Main(string[] args)
        {    ///Classandmethods
            Car swift = new Car();
            swift.color = "Black";
            Console.WriteLine("swift color" + swift.color);
            Car maruti = new Car();
            maruti.color = "pink";
            Console.WriteLine("maruti color" + maruti.color);

            ///inheritance
            Bike myBike = new Bike();
            myBike.honk();
            Console.WriteLine(myBike.brand + " " + myBike.modelName);

            ///polymorphismoverriding
            Pig pig = new Pig();
            pig.animalSound();
            Dog dog = new Dog();
            dog.animalSound();

            ///polymarphismoverloading
            PolyOverloading polyoverloading = new PolyOverloading();
            int myNum1 = polyoverloading.Add(8, 5);
            double myNum2 = polyoverloading.Add(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            ///Abstaction
             Apple f = new Apple(); 
             f.fruitTest();  // Call the abstract method
             f.sleep();  // Call the regular method

            ///Encapsulation
            DemoEncap obj = new DemoEncap();
            obj.Name = "Ankita";
            obj.Age = 21;
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
            Console.ReadLine();
        }
    }
}