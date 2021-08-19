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

            var votes = new Dictionary<string, bool>
            {
                { "Noémie", true },
                { "Aurore", false },
                { "Isabelle", false }
            };

            Console.WriteLine($"Isabelle a voté {votes["Isabelle"]}");
            Console.ReadKey(); // on attend une touche
        }
    }
}
