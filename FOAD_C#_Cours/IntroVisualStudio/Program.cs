using IntroVisualStudio.Models;
using System;

namespace IntroVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello World!");

            Point tata = new Point();

            tata = null;

            Point toto = new Point(1, 2);
            Point titi = new Point(1);
        }
    }
}
