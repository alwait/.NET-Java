using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wielowatkowosc
{

    internal class Macierz
    {
        public int[,] macierz { get; set; }

        public Macierz(int n)
        {
            macierz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    macierz[i, j] = 0;
                }
            }
        }
        public Macierz(int n, int seed)
        {
            Random random = new Random(seed);

            macierz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                     macierz[i, j] = random.Next(0,10);
                }
            }
        }

        public Macierz(int[,] tabela)
        {
            macierz = tabela;
        }
        public Macierz mnozenieMacierzy(Macierz macierz1, Macierz macierz2)
        {
            Macierz macierz3 = new Macierz(macierz1.macierz.GetLength(0));
            for (int i = 0; i < macierz1.macierz.GetLength(0); ++i)
                for (int j = 0; j < macierz1.macierz.GetLength(0); ++j)
                    for (int k = 0; k < macierz1.macierz.GetLength(0); ++k)
                        macierz3.macierz[i, j] += macierz1.macierz[i, k] * macierz2.macierz[k, j];

            return macierz3;
        }
        public override string ToString()
        {
            string macierzTekst = "";

            for (int i = 0; i < macierz.GetLength(0); ++i)
            {
                for(int j = 0; j < macierz.GetLength(1); ++j)
                {
                    macierzTekst += macierz[i, j].ToString() + " ";
                }
                macierzTekst += Environment.NewLine;
            }

            return macierzTekst;
        }
    }
}
