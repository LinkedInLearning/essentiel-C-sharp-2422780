using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var votes = new Dictionary<string, bool>
            {
                { "Noémie", true },
                { "Aurore", false },
                { "Isabelle", false }
            };

            int i = 23;

            try
            {
                Console.WriteLine($"Isabelle a voté {votes["Isabelle"]}");
            }
            catch (Exception)
            {
                Console.WriteLine("Il y a eu un problème");
            }
            finally
            {
                Console.WriteLine("C'est fini");
            }

            Console.ReadKey(); // on attend une touche
        }
    }
}
