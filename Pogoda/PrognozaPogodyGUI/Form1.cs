using PogodaAPI;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PrognozaPogodyGUI
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        private DanePogodowe danePogodowe;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            danePogodowe = new DanePogodowe();
            textMiasto.Text = "Wroc³aw";
        }

        private async void buttonAktual_ClickAsync(object sender, EventArgs e)
        {

            string call = $"https://api.openweathermap.org/data/2.5/weather?q={textMiasto.Text.ToString()}&appid=65112f46399046b01a5e2d48c6952b63&units=metric";

            string response = await client.GetStringAsync(call);

            Pogoda.root zapisPogody = JsonSerializer.Deserialize<Pogoda.root>(response);
            ZapisPogody pogoda = new ZapisPogody(zapisPogody);
            textAktual.Text = pogoda.data.ToString();
            textMiasto.Text = pogoda.miasto;
            textTemp.Text = pogoda.temperatura.ToString();
            textWilg.Text = pogoda.wilgotnosc.ToString();
            textWiatr.Text = pogoda.wiatr.ToString();

            pictureBox.ImageLocation = "https://openweathermap.org/img/wn/" + zapisPogody.weather[0].icon + ".png";
            ZapisPogody zapis = new ZapisPogody() { Id = 1, miasto = "Warszawa", temperatura = 21.37, wiatr = 1.1, wilgotnosc = 40 };
            //listBaza.Items.Add(zapisPogody.ToString());
            danePogodowe.ZapisyPogody.Add(pogoda);
            danePogodowe.SaveChangesAsync();
            listBaza.DataSource = danePogodowe.ZapisyPogody.ToList<ZapisPogody>();
        }
    }
}
