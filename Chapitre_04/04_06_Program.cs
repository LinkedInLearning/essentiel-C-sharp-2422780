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

            int i = 23;
            //Int16 s = (Int16)i;
            Int16 s = Convert.ToInt16(i);

            Int16 s2 = Convert.ToInt16(s + s);

            Console.WriteLine($"une chaîne jolie et sympa qui existe à {DateTime.Now:t}");
            //Console.WriteLine("notre araignée est " + araignee.Couleur);
            Console.ReadKey(); // on attend une touche
        }
    }
}
