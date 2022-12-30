using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class DoOddania
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Ksiazka { get; set; }
        public string OdKiedy { get; set; }
        public string DoKiedy { get; set; }
        public string Pesel { get; set; }

        public DoOddania(string imie,string nazwisko,string ksiazka, string odkiedy, string dokiedy,string pesel)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Ksiazka = ksiazka;
            this.OdKiedy = odkiedy;
            this.DoKiedy = dokiedy;
            this.Pesel = pesel;
        }
    }
}
