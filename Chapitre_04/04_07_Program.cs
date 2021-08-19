using System;
using System.Text;

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

            Int16 i = 23 * 2;

            Console.WriteLine($"une chaîne jolie et sympa qui existe à {DateTime.Now:t}");
            //Console.WriteLine("notre araignée est " + araignee.Couleur);
            Console.ReadKey(); // on attend une touche
        }
    }
}
