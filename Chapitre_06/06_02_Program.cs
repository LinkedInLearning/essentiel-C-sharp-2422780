using System;
using System.Text;

namespace ApplicationConsole
{
     class Program
    {
        static void Main(string[] args)
        {
            (string nom, ushort taille) aurelie = ("Aurélie", 185);

            if (aurelie.nom.ToUpper()[0] == 'A' || aurelie.nom.ToUpper()[0] == 'C')
            {
                Console.WriteLine($"une martienne sympa qui se nomme {aurelie.nom}");
            }
            else if (aurelie.nom.ToUpper()[0] == 'B')
            {
                Console.WriteLine($"t'appelles-tu Béatrice ?");
            }
            else
            {
                Console.WriteLine($"comment t'appelles-tu ?");
            }

            Console.ReadKey(); // on attend une touche
        }
    }
}
