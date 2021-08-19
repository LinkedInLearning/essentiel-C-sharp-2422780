using System;
using System.Text;

namespace ApplicationConsole
{
    class Personne
    {
        public string Nom;
        public int Taille;
        public DateTime DateDeNaissance;
        private TimeSpan heure = new TimeSpan(8,0,0);

        public void SeLeverLeMatin()
        {
            Console.WriteLine($"{this.Nom} se lève à {heure}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Personne aurelie = new Personne();

            aurelie.Nom = "Aurélie";
            aurelie.Taille = 180;
            aurelie.SeLeverLeMatin();

            Console.WriteLine($"une personne sympa qui se nomme {aurelie.Nom}");
            //Console.WriteLine("notre araignée est " + araignee.Couleur);
            Console.ReadKey(); // on attend une touche
        }
    }
}
