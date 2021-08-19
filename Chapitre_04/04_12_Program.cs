using System;

namespace ApplicationConsole
{
    record Insecte(string Couleur, int Taille);

    class Program
    {
        static void Main(string[] args)
        {
            Insecte araignee = new Insecte("gris", 3);
            //araignee.Couleur = "rouge"; // impossible !
        }
    }
}