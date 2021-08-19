using System;

namespace ApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Albert";
            int fois = 12;

            Console.WriteLine("attention " + nom + ", tout va exploser " + fois + " fois !");
            Console.ReadKey(); // on attend une touche
        }
    }
}
