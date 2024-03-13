using Problem_plecakowy;
namespace Problem_plecakowyInterfejs
{
    public partial class InterfejsGraficzny : Form
    {
        public InterfejsGraficzny()
        {
            InitializeComponent();
            this.Text = "Problem plecakowy";
        }

        Problem problem = new Problem();
        Result wynik = new Result();
        int iloscPrzedmiotow, seed, pojemnoscPlecaka;
        bool isSeed = false, isInstance=false, isPojemnosc=false;
        string pusto = "", zmiana= "Nastapila zmiana danych!";


        private void bOblicz_Click(object sender, EventArgs e)
        {
            if (isInstance && isSeed && isPojemnosc)
            {
                problem = new Problem(iloscPrzedmiotow, seed);
                wynik = problem.Solve(pojemnoscPlecaka);
                tDaneWyjsciowe.Text = wynik.ToString();
                tZmiana.Text = pusto;
            }
            else tDaneWyjsciowe.Text = pusto;
        }

        private void tIloscPrzedmiotow_TextChanged(object sender, EventArgs e)
        {
            if (tIloscPrzedmiotow.Text.Length > 0)
            {
                if (int.TryParse(tIloscPrzedmiotow.Text, out iloscPrzedmiotow) && iloscPrzedmiotow>0)
                {
                    tIloscPrzedmiotow.BackColor = Color.White;
                    isInstance = true;
                    if (isSeed)
                    {
                        problem = new Problem(iloscPrzedmiotow, seed);
                        tInstancja.Text = problem.ToString();
                        tZmiana.Text = zmiana;
                    }
                }
                else
                {
                    tIloscPrzedmiotow.BackColor = Color.Red;
                    isInstance = false;
                }
            }
            else
            {
                tIloscPrzedmiotow.BackColor = Color.White;
                isInstance = false;
            }

        }

        private void tSeed_TextChanged(object sender, EventArgs e)
        {
            if (tSeed.Text.Length > 0)
            {
                if (int.TryParse(tSeed.Text, out seed) && seed>=0)
                {
                    tSeed.BackColor = Color.White;
                    isSeed = true;
                    if (isInstance)
                    {
                        problem = new Problem(iloscPrzedmiotow, seed);
                        tInstancja.Text = problem.ToString();
                        tZmiana.Text = zmiana;
                    }
                }
                else
                {
                    tSeed.BackColor = Color.Red;
                    isSeed = false;
                }
            }
            else { tSeed.BackColor = Color.White; isSeed = false; }
        }

        private void tPojemoscPlecaka_TextChanged(object sender, EventArgs e)
        {
            if (tPojemoscPlecaka.Text.Length > 0)
            {
                if (int.TryParse(tPojemoscPlecaka.Text, out pojemnoscPlecaka) && pojemnoscPlecaka >=0)
                {
                    tPojemoscPlecaka.BackColor = Color.White;
                    isPojemnosc = true;
                    tZmiana.Text = zmiana;
                }
                else
                {
                    tPojemoscPlecaka.BackColor = Color.Red;
                    isPojemnosc = false;
                }
            }
            else
            {
                tPojemoscPlecaka.BackColor = Color.White;
                isPojemnosc = false;
            }
        }

    }
}
