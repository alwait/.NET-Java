using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Wielowatkowosc
{
    internal class HLP
    {
        int liczbaWatkow;
        public Macierz wynik;
        ParallelOptions opt;

        public HLP(int n) { 
        liczbaWatkow = n;
            opt = new ParallelOptions() { MaxDegreeOfParallelism = n};
        }

        public TimeSpan mnozenieMacierzy(Macierz macierz1, Macierz macierz2)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            wynik = new Macierz(macierz1.macierz.GetLength(0));

            Parallel.For(0, wynik.macierz.GetLength(0), opt, x => {
                for (int j = 0; j < wynik.macierz.GetLength(0); ++j)
                    for (int k = 0; k < wynik.macierz.GetLength(0); ++k)
                        wynik.macierz[x, j] += macierz1.macierz[x, k] * macierz2.macierz[k, j];
            });

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
