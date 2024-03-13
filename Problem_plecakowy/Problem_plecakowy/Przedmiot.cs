using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Problem_plecakowyTesty"), InternalsVisibleTo("Problem_plecakowyInterfejs")]

namespace Problem_plecakowy
{
    internal class Przedmiot
    {
        int wartosc;
        int waga;
        bool pobrano;
        int nrPrzedmiotu;
        float kryterium;

        public Przedmiot(int wartosc, int waga, int nrPrzedmiotu)
        {
            this.wartosc = wartosc;
            this.waga = waga;
            this.pobrano = false;
            this.nrPrzedmiotu = nrPrzedmiotu;
            this.kryterium = (float)wartosc/(float)waga;
        }
        public int GetNrPrzedmiotu() {  return nrPrzedmiotu; }
        public int GetWartosc() { return wartosc; }
        public int GetWaga() {  return waga; }
        public float GetKryterium() { return kryterium;  }
        public void setPobrano() { pobrano = true; }
        public bool getPobrano() { return pobrano; }
    }
}
