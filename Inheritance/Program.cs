using System;
using System.Security.Cryptography;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create an object of your Bird class
             * give values to your members using the object ofm your Bird class
             * 
             * Creatively display the class member values
             */

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true

            };

            var myAnimals = new Animal[] { myBird, lizard };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has{animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");
            }
        }

    }

}


        
    












