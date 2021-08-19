using System;
using System.Text;

namespace ApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            (string nom, ushort taille) aurelie = ("Aurélie", 185);

            var s = "ANNIVERSAIRE";

            for (var i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"Lettre : {s[i]}");
            }

            Console.ReadKey(); // on attend une touche
        }
    }
}
