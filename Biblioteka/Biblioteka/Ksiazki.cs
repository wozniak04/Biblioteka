using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazki
    {
        public string Ksiazka { get; set; }
        public string OdKiedy { get; set; }
        public string DoKiedy { get; set; }
        public Ksiazki(string ksiazka,string odkiedy,string dokiedy)
        {
            this.Ksiazka = ksiazka;
            this.OdKiedy = odkiedy;
            this.DoKiedy = dokiedy;
        }
    }
}
