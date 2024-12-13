using System;
using System.Diagnostics.SymbolStore;

namespace loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            int tal = int.Parse(Console.ReadLine());
            while (tal != 0)
            {
                Console.WriteLine("Skriv in ett annat heltal");
                tal = int.Parse(Console.ReadLine());
            }
        }
    }
}