using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement_Tabsters
{
    class Magasin
    {
        public List<Animal> animaux { get; set; } = new List<Animal>();
        public double tresorerie { get; set; } = 0;


        public void AjouterAnimal(Animal animal)
        {
            animaux.Add(animal);
        }

        public void SupprimerAnimal(Animal animal)
        {
            animaux.Remove(animal);
        }

        public bool AcheterAnimal(Animal animal)
        {
            if (tresorerie < animal.prix)
            {
                Console.WriteLine("Prix de l'animal non abordable");
                return false;
            }
            else
            {
                tresorerie -= animal.prix;
                AjouterAnimal(animal);
                return true;
            }
            
        }

        public bool AcheterAnimaux(List<Animal> animaux)
        {
            foreach (var animal in animaux)
            {
               AcheterAnimal(animal);
            }
            return false;
        }

        public void VendreAnimal(Animal animal)
        {
            tresorerie += animal.prix;
            SupprimerAnimal(animal);
        }

        public void VendreAnimaux(List<Animal> animaux)
        {
            foreach (var animal in animaux)
            {
                tresorerie += animal.prix;
                SupprimerAnimal(animal);
            }
        }
    }
}
