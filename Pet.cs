using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern_Assignment
{
    public class Pet
    {
        public Pet()
        {

        }
        public Pet( string name, string age, string species)
        {
            name = Name;
            age =Age;
            species = Species;
        }
        public string Name { get; set; } = string.Empty;
        public string Age { get; set; }
        public string Species { get; set; } = string.Empty;
        public override string ToString()
        {
            return $" Name: {Name} - Age: {Age} years old -  Spesies: {Species}";
        }

    }
   
}
