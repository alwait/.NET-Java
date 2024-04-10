using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wielowatkowosc
{
    internal class LLT
    {
        Thread[] watki;
        public volatile Macierz wynik;
        public LLT(int n)
        {
            watki = new Thread[n];
        }
        public TimeSpan mnozenieMacierzy(Macierz macierz1, Macierz macierz2) {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            wynik = new Macierz(macierz1.macierz.GetLength(0));
            int przydzialWatku = (int)Math.Ceiling((float)(macierz1.macierz.GetLength(0))/(float)watki.GetLength(0));

            for (int i = 0; i < watki.GetLength(0); ++i) {
                int l = i;
                watki[i] = new Thread(() => pomnoz(macierz1, macierz2, l, przydzialWatku));
            }

            foreach (Thread x in watki) x.Start();
            foreach (Thread x in watki) x.Join();

            stopwatch.Stop();
            return stopwatch.Elapsed;

        }
        public void pomnoz(Macierz macierz1, Macierz macierz2, int nrWatku, int przydzial)
        {
            int wierszStart = nrWatku*przydzial;
            int wierszStop = wierszStart+przydzial;
            if (wierszStop > wynik.macierz.GetLength(0)) wierszStop = wynik.macierz.GetLength(0);
            //Console.WriteLine("Watek " + nrWatku + ": " + wierszStart + "->" + wierszStop);

            for (int i = wierszStart; i < wierszStop; ++i)
                for (int j = 0; j < wynik.macierz.GetLength(0); ++j)
                    for (int k = 0; k < wynik.macierz.GetLength(0); ++k)
                        wynik.macierz[i, j] += macierz1.macierz[i, k] * macierz2.macierz[k, j];
            //Console.WriteLine("Watek dziala");

        }

    }
}
