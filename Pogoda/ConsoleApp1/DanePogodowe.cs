using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("PrognozaPogodyGUI")]

namespace PogodaAPI
{
    internal class DanePogodowe : DbContext
    {
        public DbSet<ZapisPogody> ZapisyPogody {  get; set; }
        public DanePogodowe()
        {
            Database.EnsureCreatedAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=DanePogodowe.db", opt => 
            { 
                opt.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(options);
        }
        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ZapisPogody>().HasData(
                new ZapisPogody() { Id = 1, miasto = "Warszawa", temperatura=21.37, wiatr=1.1, wilgotnosc=40},
                new ZapisPogody() { Id = 2, miasto = "Kraków", temperatura = 15.12, wiatr = 0.4, wilgotnosc = 61},
                new ZapisPogody() { Id = 3, miasto = "Łódź", temperatura = 10.5, wiatr = 1.7, wilgotnosc = 52}
                );
        }
    }
}
