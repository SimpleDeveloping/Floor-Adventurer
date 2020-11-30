using System;

namespace floor_adventurer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Floor Adventure");
            Console.WriteLine("By SimpleDeveloping");
            Console.WriteLine("Press [P] to play, press [X] to quit.");
            ConsoleKeyInfo
            cki = Console.ReadKey();
            do
            { 
                cki = Console.ReadKey();
                if (cki.ToString() == )
                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape) ;

        }
    }
}
