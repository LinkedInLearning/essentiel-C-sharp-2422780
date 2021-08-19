using System;
using System.Text;

namespace ApplicationConsole
{
    interface Personne
    {
        short Taille { get; set; }

        string Nom { get; set; }
        DateTime DateDeNaissance { get; set; }

        void SeLeverLeMatin(TimeSpan heure, int reveils);

    }

    class Martien : Personne
    {
        public bool ADesAntennes { get; set; }
        public short Taille { get; set; }
        public string Nom { get; set; }
        public DateTime DateDeNaissance { get; set; }

        public void SeLeverLeMatin(TimeSpan heure, int reveils)
        {
            // coucou
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Personne aurelie = new Martien();

            aurelie.Nom = "Aurélie";
            aurelie.SeLeverLeMatin(new TimeSpan(8, 0, 0), 42);

            Console.WriteLine($"une martienne sympa qui se nomme {aurelie.Nom}");
            Console.ReadKey(); // on attend une touche
        }
    }
}