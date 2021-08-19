using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var noms = new List<string>() { "Noémie", "Aurore", "Isabelle", "Gwen", "Francine", "Greta" };
            // iEnumerable

            foreach (var nom in noms)
            {
                Console.WriteLine($"{nom} est sympa !");
            }

            Console.ReadKey(); // on attend une touche
        }
    }
}
