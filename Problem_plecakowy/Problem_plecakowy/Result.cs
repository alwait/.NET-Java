using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Problem_plecakowyTesty"), InternalsVisibleTo("Problem_plecakowyInterfejs")]

namespace Problem_plecakowy
{
    internal class Result
    {
        List<int> numeryPrzedmiotow;
        int sumWartosc;
        int sumWaga;
        int iloscPrzedmiotow;
    public Result()
    {
            numeryPrzedmiotow = new List<int>();
            sumWartosc = 0;
            sumWaga = 0;
            iloscPrzedmiotow= 0;
    }
        public int GetIloscPrzedmiotow() { return iloscPrzedmiotow; }
        public List<int> GetNumeryPrzedmiotow() { return numeryPrzedmiotow;}
        public int GetWartosc() { return sumWartosc; }
        public int GetWaga() { return sumWaga; }
        public void inputPrzedmiot(int nrPrzedmiotu, int Wartosc, int Waga)
    {
            this.numeryPrzedmiotow.Add(nrPrzedmiotu);
            this.sumWartosc += Wartosc;
            this.sumWaga += Waga;
            this.iloscPrzedmiotow++;
    }
        public override string ToString()
    {
            string statystyki="Przemioty nr: ";
            for(int i = 0; i<this.iloscPrzedmiotow; ++i)
            {
                statystyki += numeryPrzedmiotow[i];
                if (i < this.iloscPrzedmiotow - 1) statystyki += ", ";
            }
            statystyki += Environment.NewLine + "Wartosc plecaka: " + this.sumWartosc;
            statystyki += Environment.NewLine + "Waga plecaka: " + this.sumWaga;

            return statystyki;
    }

    }
}
