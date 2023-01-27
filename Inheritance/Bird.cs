using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public int Wings { get; set; }

        public string Type { get; set; }

        public string FeatherSize { get; set; }

        public bool IsNocturnal { get; set; }
        public Bird()
        {


        }
        public Bird(int wings, string type, string featherSize, bool isNocturnal, int age, int eyes, string name, bool isMammal)
        {
            Wings = wings;
            Type = type;
            FeatherSize = featherSize;
            IsNocturnal = isNocturnal;
            Age = age;
            Eyes = eyes;
            Name = name;
            IsMammal = isMammal;

        }
    }
}
