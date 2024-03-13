using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Problem_plecakowyTesty"), InternalsVisibleTo("Problem_plecakowyInterfejs")]

namespace Problem_plecakowy
{
    internal class Problem
    {
        int liczbaPrzedmiotow;
        List<Przedmiot> magazyn;
        
        public Problem()
        {
            liczbaPrzedmiotow= 0;
            magazyn = new List<Przedmiot>();
        }
        public Problem(int liczbaPrzedmiotow, int seed)
        {
            magazyn = new List<Przedmiot>();
            this.liczbaPrzedmiotow = liczbaPrzedmiotow;
            Random random = new Random(seed);
            for (int i = 0; i < liczbaPrzedmiotow; ++i)
            {
                this.magazyn.Add(new Przedmiot(random.Next(1, 11), random.Next(1, 11), i));
            }
        }
        public Problem(int liczbaPrzedmiotow, List<Przedmiot> przedmioty)
        {
            this.liczbaPrzedmiotow = liczbaPrzedmiotow;
            magazyn = new List<Przedmiot>();
            magazyn = przedmioty;
            
        }
        public Result Solve(int Pojemnosc)
        {
            int pozostalaPojemnosc = Pojemnosc;
            Result result = new Result();
            Problem sortownik = this;
            sortownik.GetListaPrzedmiotow().Sort((x, y) => x.GetKryterium().CompareTo(y.GetKryterium()));
            sortownik.GetListaPrzedmiotow().Reverse();
            for (int i = 0; i < sortownik.GetLiczbaPrzedmiotow(); ++i)
            {
                if (sortownik.GetListaPrzedmiotow()[i].GetWaga() <= pozostalaPojemnosc)
                {
                    sortownik.GetListaPrzedmiotow()[i].setPobrano();
                    pozostalaPojemnosc -= sortownik.GetListaPrzedmiotow()[i].GetWaga();
                }
            }

            Console.WriteLine(sortownik.ToString()); // sprawdzenie kolejnosci po sortowaniu

            for (int i = 0; i < sortownik.GetLiczbaPrzedmiotow(); ++i)
            {
                if (sortownik.GetListaPrzedmiotow()[i].getPobrano() == true)
                {
                    result.inputPrzedmiot(sortownik.GetListaPrzedmiotow()[i].GetNrPrzedmiotu(), sortownik.GetListaPrzedmiotow()[i].GetWartosc(), sortownik.GetListaPrzedmiotow()[i].GetWaga());
                }
            }



            return result;
        }
        public void inputPrzedmiot(Przedmiot przedmiot)
        {
            liczbaPrzedmiotow++;
            magazyn.Add(przedmiot);
        }
        public int GetLiczbaPrzedmiotow() { return this.liczbaPrzedmiotow; }
        public List<Przedmiot> GetListaPrzedmiotow() { return magazyn; }
        public int GetNrPrzedmiotu(int i) { return 0; }
        public void WypiszInstancjeProblemu()
        {
            for (int i = 0; i < this.GetLiczbaPrzedmiotow(); i++)
            {
                Console.Write("nr: " + i);
                Console.Write("   v: " + this.GetListaPrzedmiotow()[i].GetWartosc());
                Console.WriteLine("   w: " + this.GetListaPrzedmiotow()[i].GetWaga());
            }
        }
        public override string ToString()
        {
            string statystyki = "";

            for(int i = 0; i < liczbaPrzedmiotow; ++i)
            {
                statystyki += "nr: " + magazyn[i].GetNrPrzedmiotu();
                statystyki += "   v: " + magazyn[i].GetWartosc();
                statystyki += "   w: " + magazyn[i].GetWaga();
                statystyki += Environment.NewLine;
            }

            return statystyki;
        }
    }
}
