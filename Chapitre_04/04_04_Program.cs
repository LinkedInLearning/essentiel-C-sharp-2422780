using System;

namespace ApplicationConsole
{
    struct Insecte
    {
        public string Couleur;
        public int Taille;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Insecte araignee = new Insecte()
            {
                Couleur = "gris",
                Taille = 3
            };

            string nom = $$"""
                Noémie et "Aurélie" 
                    {{araignee.Couleur}}
                """;
            string chemin = $@"c:\Windows\System {nom}";
            string remarque = String.Format("une chaîne {0} et {1}", "jolie", "sympa");

            Console.WriteLine("une chaîne {0} et {1}", "jolie", "sympa");
            Console.WriteLine("notre araignée est " + araignee.Couleur);
            Console.ReadKey(); // on attend une touche
        }
    }
}