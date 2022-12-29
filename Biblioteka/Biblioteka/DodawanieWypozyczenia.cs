using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class DodawanieWypozyczenia : Form
    {
        public DodawanieWypozyczenia()
        {
            InitializeComponent();
        }

        private void bDodaj_Click(object sender, EventArgs e)
        {
            var pol = new Polaczenie();
            string imie = tImie.Text.ToString();
            string nazwisko = tNazwisko.Text.ToString();
            string ksiazka = tTytul.Text.ToString();
            string pesel = Tpesel.Text.ToString();
            pol.dodajksiazke(imie,nazwisko,ksiazka,pesel);
        }
    }
}
