namespace PogodaAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            API api = new API();
            api.GetData().Wait();
            ZapisPogody zapis = new ZapisPogody() { Id = 1, miasto = "Warszawa", temperatura = 21.37, wiatr = 1.1, wilgotnosc = 40 };
            Console.WriteLine(zapis.ToString());
            DanePogodowe danePogodowe = new DanePogodowe();
            danePogodowe.ZapisyPogody.Add(new ZapisPogody() { miasto = "Warszawa", temperatura = 21.37, wiatr = 1.1, wilgotnosc = 40 });
            danePogodowe.SaveChanges();
        }
    }
}
