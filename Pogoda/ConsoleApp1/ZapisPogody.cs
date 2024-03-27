using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PogodaAPI.Pogoda;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace PogodaAPI
{
    [PrimaryKey(nameof(Id))]
    public class ZapisPogody
    {
        public int Id { get; set; }
        public string miasto { get; set; }
        public double temperatura { get; set; }
        public double wilgotnosc { get; set; }
        public double wiatr { get; set; }
        public DateTime data { get; set; }

        public ZapisPogody() { miasto = ""; }
        public ZapisPogody(Pogoda.root pogoda)
        {
            miasto = pogoda.name;
            temperatura = pogoda.main.temp;
            wilgotnosc = pogoda.main.humidity;
            wiatr = pogoda.wind.speed;
            data = pogoda.Date;
        }

        public ZapisPogody(int id, string Miasto, double Temperatura, double Wilgotnosc, double Wiatr, string Opis, DateTime Data)
        {
            Id=id;
            miasto=Miasto;
            temperatura=Temperatura;
            wilgotnosc=Wilgotnosc;
            wiatr=Wiatr;
            data=Data;
        }

        public override string ToString()
        {
            return $"{data}" + Environment.NewLine + $"Miasto: {miasto}, Temperatura: {temperatura} C, Wilgotnosc: {wilgotnosc}%, Wiatr: {wiatr} m/s";
        }
    }

}
