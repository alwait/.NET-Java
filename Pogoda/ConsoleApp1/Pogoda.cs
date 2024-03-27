using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PogodaAPI
{
    public class Pogoda
    {
        public int Id { get; set; }
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }
        public class main
        {
            public double temp { get; set; } // Temperatura
            public double humidity { get; set; } // Wilgotnosc
        }
        public class wind
        {
            public double speed { get; set; }
        }

        public class root
        {
            public string name { get; set; }
            
            public List <weather> weather { get; set; }

            public main main { get; set; }
            public wind wind { get; set; }
            public DateTime Date { get; set; } = DateTime.Now;


            public override string ToString()
            {
                return $"{Date} {Environment.NewLine} Miasto: {name}, Temperatura: {main.temp} C, Wilgotnosc: {main.humidity}%, Wiatr: {wind.speed} m/s";
            }
        }

    }
}
