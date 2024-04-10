namespace Wielowatkowosc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2000;
            int w = 10;
            Macierz macierz1 = new Macierz(n, 1);
            Macierz macierz2 = new Macierz(n, 2);

            //Console.WriteLine(macierz1.ToString());
            //Console.WriteLine(macierz2.ToString());
            //Console.WriteLine(new Macierz(n).mnozenieMacierzy(macierz1,macierz2).ToString());

            LLT mnozenieL = new LLT(w);
            TimeSpan czasL = mnozenieL.mnozenieMacierzy(macierz1, macierz2);
            //Console.WriteLine("LowLevelThreading:" + Environment.NewLine + mnozenieL.wynik.ToString());

            HLP mnozenieH = new HLP(w);
            TimeSpan czasH = mnozenieH.mnozenieMacierzy(macierz1, macierz2);
            //Console.WriteLine("HighLevelParallelism:" + Environment.NewLine + mnozenieH.wynik.ToString());

            Console.WriteLine("N: " + n + " W: " + w);
            Console.WriteLine("L:" + czasL);
            Console.WriteLine("H:" + czasH);
        }
    }
}
