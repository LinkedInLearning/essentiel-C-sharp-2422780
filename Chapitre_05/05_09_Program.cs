using System;
using System.Text;

namespace ApplicationConsole
{
    abstract class Personne
    {
        public short Taille { get; private set; } = 180;

        public string Nom;
        public DateTime DateDeNaissance;

        public void SeLeverLeMatin(TimeSpan heure, int reveils = 42)
        {
            Console.WriteLine($"{this.Nom} se lève à {heure}");
            Taille = 180;
        }

    }

    class Martien: Personne
    {
        public bool ADesAntennes { get; set; }
    }

    class Facteur : Personne
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            var aurelie = new Martien();

            aurelie.Nom = "Aurélie";
            aurelie.SeLeverLeMatin(new TimeSpan(8, 0, 0));

            Console.WriteLine($"une martienne sympa qui se nomme {aurelie.Nom}");
            Console.ReadKey(); // on attend une touche
        }
    }
}
