namespace PetShopManagement_Tabsters
{ 

    class Program
    {
        static void Main(string[] args)
        {

               // créer le magasin avec un capital de 1000e 
                Magasin magasin = new Magasin();
                magasin.tresorerie = 1000;

                //alimenter liste des animaux dans le magasin:

                Animal chien1 = new Chien();
                Animal chat1 = new Chat();

                Animal chien2 = new Chien();
                Animal chat2 = new Chat();

                Animal chien3 = new Chien();
                Animal chat3 = new Chat();

                List<Animal> animaux = new List<Animal> { chien1, chat1, chien2, chat2, chien3, chat3 };


                magasin.AcheterAnimaux(animaux);
                List<Animal> animauxDisponibles = magasin.animaux;


                // afficher les informations du magasin 
                Console.WriteLine("************ T0 **********************");
                Console.WriteLine("-----Liste Animaux disponible à T0----------");
                foreach (var animal in animauxDisponibles)
                {
                    Console.WriteLine($"Type de l'animal :{animal.type}, Prix de l'animal : {animal.prix}");

                }

                Console.WriteLine($"Trésorerie à T0: {magasin.tresorerie}");



                //alimenter la trésorerie 
                List<Animal> animauxàVendre = new List<Animal> { animauxDisponibles[0], animauxDisponibles[1] };
                magasin.VendreAnimaux(animauxàVendre);

                // afficher les informations du magasin 
                Console.WriteLine("************ T1 **********************");
                Console.WriteLine("-----Liste Animaux disponible à T1 ----------");
                foreach (var animal in animauxDisponibles)
                {
                    Console.WriteLine($"Type de l'animal :{animal.type}, Prix de l'animal : {animal.prix}");

                }

                Console.WriteLine($"Trésorerie à T1: {magasin.tresorerie}");

                // Achat d'un nouvel animal 
                Animal chien = new Chien();
                magasin.AcheterAnimal(chien);

                //afficher les informations du magasin
                Console.WriteLine("************ T2 **********************");
                Console.WriteLine("-----Liste Animaux disponible à T2 ----------");
                foreach (var animal in animauxDisponibles)
                {
                    Console.WriteLine($"Type de l'animal :{animal.type}, Prix de l'animal : {animal.prix}");

                }
                Console.WriteLine($"Trésorerie à T2: {magasin.tresorerie}");

                // vendre un animal
                Animal animalàVendre = animauxDisponibles[0];
                magasin.VendreAnimal(animalàVendre);

                //afficher les informations du magasin
                Console.WriteLine("************ T3 **********************");
                Console.WriteLine("-----Liste Animaux disponible à T3 ----------");
                foreach (var animal in animauxDisponibles)
                {
                    Console.WriteLine($"Type de l'animal :{animal.type}, Prix de l'animal : {animal.prix}");

                }
                Console.WriteLine($"Trésorerie à T3: {magasin.tresorerie}");



        }
    }
}
