using Problem_plecakowy;
using System.Runtime.CompilerServices;


namespace Problem_plecakowyTesty
{
    [TestClass]
     public class TestyJednostkowe
    {
        [TestMethod]
        public void TestSpelnieniaOgraniczenia()
        {
            
            Problem problem = new Problem(10,1);

            Przedmiot dobryPrzedmiot = new Przedmiot(6, 2, 11);

            problem.inputPrzedmiot(dobryPrzedmiot);

            Result wynik = new Result();
            wynik = problem.Solve(20);

            Assert.IsTrue(wynik.GetNumeryPrzedmiotow().Count >= 1);
        }
        [TestMethod]
        public void TestNiespelnieniaOgraniczenia()
        {
            List<Przedmiot> przedmioty = new List<Przedmiot>();

            for (int i = 0; i < 4; i++)
            {
                przedmioty.Add(new Przedmiot(1, 6 + i, i));
            }

            Problem problem = new Problem(4, przedmioty);

            Result wynik = new Result();
            wynik = problem.Solve(5);

            Assert.IsTrue(wynik.GetNumeryPrzedmiotow().Count == 0);
        }
        [TestMethod]
        public void TestKolejnosciPrzedmiotow()
        {
            Problem problem = new Problem(30, 1);

            List<Przedmiot> przedmioty = new List<Przedmiot>();

            przedmioty=problem.GetListaPrzedmiotow();
            przedmioty.Reverse();

            Problem problemOdwrocony = new Problem(30,przedmioty);

            Result wynik = new Result();
            wynik = problem.Solve(100);
            Result wynikOdwrocony = problemOdwrocony.Solve(100);

            Assert.AreNotEqual(problem, problemOdwrocony);
        }
        [TestMethod]
        public void TestPoprawnosciWynikowInstancjiSprawdzajacej()
        {
            List<Przedmiot> przedmioty = new List<Przedmiot>();

            for (int i = 0; i < 10; i++)
            {
                przedmioty.Add(new Przedmiot(i+1, 10-i, i));
            }
            Problem problem = new Problem(10, przedmioty);
            Result wynik = new Result();
            wynik = problem.Solve(6);

            List<int> poprawneNumery = new List<int>(new int[] {9, 8, 7});

            Assert.IsTrue(poprawneNumery.SequenceEqual(wynik.GetNumeryPrzedmiotow()));

        }
        [TestMethod]
        public void TestZakresuParametrowPrzedmiotowLosowanych()
        {
            Problem problem = new Problem(10, 1);

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(problem.GetListaPrzedmiotow()[i].GetWartosc(), 5 , 5);
                Assert.AreEqual(problem.GetListaPrzedmiotow()[i].GetWaga(), 5, 5);
            }

        }
        [TestMethod]
        public void TestLiczeniaKryterium()
        {
            Problem problem = new Problem(10, 1);

            for(int i = 0;i < 10;i++)
            {
                Assert.AreEqual((float)problem.GetListaPrzedmiotow()[i].GetWartosc()/(float)problem.GetListaPrzedmiotow()[i].GetWaga(), problem.GetListaPrzedmiotow()[i].GetKryterium());  
            }

        }
        [TestMethod]
        public void TestSumowaniaParametrowWyniku()
        {
            Problem problem = new Problem(10, 1);

            Result wynik = new Result();
            wynik = problem.Solve(100);

            int sumWaga=0, sumWartosc=0;

            for (int i = 0; i < 10; i++)
            {
                sumWartosc += problem.GetListaPrzedmiotow()[i].GetWartosc();
                sumWaga += problem.GetListaPrzedmiotow()[i].GetWaga();
            }

            Assert.AreEqual(sumWartosc, wynik.GetWartosc());
            Assert.AreEqual(sumWaga, wynik.GetWaga());

        }
        [TestMethod]
        public void TestRoznorodnosciParametrowOdZiarna()
        {
            Problem problem1 = new Problem(100, 1445);
            Problem problem2 = new Problem(100, 13);

            List<int> wagi1 = new List<int>();
            List<int> wagi2 = new List<int>();

            List<int> wartosci1 = new List<int>();
            List<int> wartosci2 = new List<int>();

            for (int i = 0;i < 100; i++)
            {
                wartosci1.Add(problem1.GetListaPrzedmiotow()[i].GetWartosc());
                wagi1.Add(problem1.GetListaPrzedmiotow()[i].GetWaga());

                wartosci2.Add(problem2.GetListaPrzedmiotow()[i].GetWartosc());
                wagi2.Add(problem2.GetListaPrzedmiotow()[i].GetWaga());
            }

            Assert.IsFalse(wartosci1.SequenceEqual(wartosci2));
            Assert.IsFalse(wagi1.SequenceEqual(wagi2));
        }


    }
}