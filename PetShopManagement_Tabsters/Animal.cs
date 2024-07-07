using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement_Tabsters
{
      abstract class Animal
    {
        public double prix { get; set; }
        public string type { get; set; }

        public Animal(double prix,string type)
        {
            this.prix = prix;
            this.type = type;
        }

        public Animal() { }

        public Animal(Animal animal)
        {
            prix= animal.prix;
            type= animal.type;
        }


    }
}
