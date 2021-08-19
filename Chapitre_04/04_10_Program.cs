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

            int[][] i = {new int[] { 12, 2 }, new int[] { 24, 4 }, new int[] { 36, 6 } };

            Console.WriteLine($"une chaîne jolie et sympa qui a la valeur {i[1][0]}");
            //Console.WriteLine("notre araignée est " + araignee.Couleur);
            Console.ReadKey(); // on attend une touche
        }
    }
}
