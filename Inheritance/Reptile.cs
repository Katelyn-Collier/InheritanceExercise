using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string Home { get; set; }

        public string Variety { get; set; }

        public string ScaleColor { get; set; }

        public bool IsFireBreathing { get; set; }

        public Reptile()
        {



        }
        public Reptile(string home, string variety, string scaleColor, bool isFireBreathing, int age, int eyes, string name, bool isMammal)
        {
            Home = home;
            Variety = variety;
            ScaleColor = scaleColor;
            IsFireBreathing = isFireBreathing;
            Age = age;
            Eyes = eyes;
            Name = name;
            IsMammal = isMammal;
        }
    }
}
