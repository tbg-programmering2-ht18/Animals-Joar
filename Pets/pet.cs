using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public bool CanFly { get; set; }

        public string Show()
        {
            if (CanFly == true)
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2} and can fly", Name, Sound, GetType());
            }
            else
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2}", Name, Sound, GetType());
            }
        }

    }
    class Dog : Pet
    {
        public Dog(String name)
        {
            Name = name;
            Sound = "WOFF!";
            CanFly = false;
        }
    }
    class Duck : Pet
    {
        public Duck(String name)
        {
            Name = name;
            Sound = "Kvack!";
            CanFly = false;
        }
    }
    class Lion : Pet
    {
        public Lion(String name)
        {
            Name = name;
            Sound = "ROAAR!";
            CanFly = true;
        }
    }
}
