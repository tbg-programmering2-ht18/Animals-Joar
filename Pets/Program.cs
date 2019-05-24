using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static List<Pet> pets = new List<Pet>(); //create list

        static void Main(string[] args)
        {

            pets.Add(new Dog("harry")); //Adds things to the pets list
            pets.Add(new Lion("simba"));
            pets.Add(new Duck("sven"));

            Console.WriteLine(pets.Show());
            Console.ReadKey();

            
        }
    }
}