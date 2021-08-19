using System;

namespace ApplicationConsole
{
    class EtreHumain
    {
        public char Sexe;
        public ushort AnneeDeNaissance;
    }

    struct Insecte
    {
        public string Couleur;
        public int Taille;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Albert";
            char fois = '好';

            EtreHumain ami = new EtreHumain();
            Insecte araignee = new Insecte()
            {
                Couleur = "gris",
                Taille = 3
            };

            EtreHumain ennemi = ami;
            Insecte mouche = araignee;

            ami.Sexe = 'F';
            araignee.Couleur = "vert";

            Console.WriteLine(ami.GetType());
            Console.WriteLine(ennemi.GetType().IsValueType);
            Console.WriteLine(mouche.GetType().IsValueType);

            Console.WriteLine(Object.ReferenceEquals(ami, ennemi));
            Console.WriteLine(Object.ReferenceEquals(mouche, araignee));

            Console.WriteLine("attention " + nom + ", tout va exploser " + fois + " fois !");
            Console.ReadKey(); // on attend une touche
        }
    }
}
