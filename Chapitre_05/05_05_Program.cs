using System;
using System.Text;

namespace ApplicationConsole
{
    class Personne
    {
        //private short taille;

        public short Taille { get; init; } = 180;
        //{
        //    get
        //    {
        //        return taille;
        //    }

        //    set
        //    {
        //        taille = value;
        //    }
        //}

        //{ get; private set; } = 180;

        public string Nom;
        public DateTime DateDeNaissance;
        private TimeSpan heure = new TimeSpan(8, 0, 0);

        public void SeLeverLeMatin()
        {
            Console.WriteLine($"{this.Nom} se lève à {heure}");
            //Taille = 180;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Personne aurelie = new Personne()
            {
                Taille = 180
            };

            aurelie.Nom = "Aurélie";
            
            aurelie.SeLeverLeMatin();

            Console.WriteLine($"une personne sympa qui se nomme {aurelie.Nom}");
            //Console.WriteLine("notre araignée est " + araignee.Couleur);
            Console.ReadKey(); // on attend une touche
        }
    }
}