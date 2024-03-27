using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PogodaAPI
{
    public class API
    {
        public HttpClient client;
        public async Task GetData()
        {
            client=new HttpClient();
            string call = "https://api.openweathermap.org/data/2.5/weather?q=Wroclaw&appid=65112f46399046b01a5e2d48c6952b63&units=metric&lang=pl";
            string response = await client.GetStringAsync(call);
            Pogoda.root zapisPogody = JsonSerializer.Deserialize<Pogoda.root>(response);
            //Console.WriteLine(response);
            Console.WriteLine(zapisPogody.ToString());
        }
    }
}
