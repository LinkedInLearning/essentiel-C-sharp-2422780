using System;
using System.Text;

namespace ApplicationConsole
{
    class Personne
    {
        public short Taille { get; private set; } = 180;

        public string Nom;
        public DateTime DateDeNaissance;
        //private TimeSpan heure = new TimeSpan(8,0,0);

        public Personne(short taille)
        {
            this.Taille = taille;
        }

        public Personne()
        {
            this.Taille = 170;
        }

        public void SeLeverLeMatin(TimeSpan heure)
        {
            Console.WriteLine($"{this.Nom} se lève à {heure}");
            Taille = 180;
        }
        public void SeLeverLeMatin(TimeSpan heure, int reveils)
        {
            Console.WriteLine($"{this.Nom} se lève à {heure}");
            Taille = 180;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Personne aurelie = new(170);

            aurelie.Nom = "Aurélie";
            //aurelie.Taille = 180;
            aurelie.SeLeverLeMatin(new TimeSpan(8, 0, 0));

            Console.WriteLine($"une personne sympa qui se nomme {aurelie.Nom}");
            //Console.WriteLine("notre araignée est " + araignee.Couleur);
            Console.ReadKey(); // on attend une touche
        }
    }
}