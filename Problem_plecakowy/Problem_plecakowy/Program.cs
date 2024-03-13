using System.Collections.Generic;
using System.Dynamic;

namespace Problem_plecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program - problem plecakowy" + Environment.NewLine);

            Console.WriteLine("Podaj liczbe przedmiotow: ");
            string liczbaPrzedmiotow = Console.ReadLine();
            int lP;
            int.TryParse(liczbaPrzedmiotow, out lP);

            Console.WriteLine("Podaj ziarno: ");
            string ziarno = Console.ReadLine();
            int z;
            int.TryParse(ziarno, out z);

            Problem problem = new Problem(lP, z);
            Console.WriteLine(problem.ToString());

            Console.WriteLine("Podaj pojemosc plecaka: ");
            string pojemnoscPlecaka = Console.ReadLine();
            int pP;
            int.TryParse(pojemnoscPlecaka, out pP);

            Result rozwiazanie = new Result();
            rozwiazanie = problem.Solve(pP);
       
            Console.WriteLine(rozwiazanie.ToString());
        }
    }
}
