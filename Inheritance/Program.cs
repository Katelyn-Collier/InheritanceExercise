using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird sam = new Bird()
            {
                Name = "Sam",
                Type = "tropical toucan",
                Age = 60,
                Eyes = 2,
                Wings = 2,
                FeatherSize = "medium sized feathers",
                IsMammal = false,
                IsNocturnal = false,

            };

            Console.WriteLine($"{sam.Name} is a {sam.Type} who is {sam.Age} years old. He has {sam.Eyes} eyes, {sam.Wings} wings, and {sam.FeatherSize}. Is Sam a mammal? {sam.IsMammal}. Is Sam nocturnal? {sam.IsNocturnal}.");
            Console.ReadLine();




            Reptile rha = new Reptile()
            {
                Name = "Rhaegal",
                Variety = "dragon",
                Age = 7,
                Eyes = 2,
                Home = "Lhazar",
                ScaleColor = "dark green",
                IsMammal = false,
                IsFireBreathing = true,
            };

            Console.WriteLine($"{rha.Name} is a {rha.Variety} who belonged to Daenerys Targaryen. He has {rha.Eyes} eyes and {rha.ScaleColor} scales. {rha.Name} was born in {rha.Home} and died at the age of {rha.Age}. Is Rhaegal a mammal? {rha.IsMammal}. Is Rhaegal fire breathing? {rha.IsFireBreathing}.");
            Console.ReadLine();








            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
