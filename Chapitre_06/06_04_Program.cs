using System;
using System.Text;

namespace ApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            (string nom, ushort taille) aurelie = ("Aurélie", 185);

            var aujourdhui = DateTime.Today;

            switch (aujourdhui.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("On est lundi");
                    //...
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("On est mardi");
                    //...
                    break;
                default:
                    Console.WriteLine("Connais pas !");
                    break;
            }

            Console.ReadKey(); // on attend une touche
        }
    }
}
