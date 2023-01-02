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
            if(!(string.IsNullOrEmpty(tImie.Text) && string.IsNullOrEmpty(tNazwisko.Text) && string.IsNullOrEmpty(tTytul.Text) && string.IsNullOrEmpty(Tpesel.Text)))
                if (pol.DodajWypozyczenie(tImie.Text, tNazwisko.Text, tTytul.Text, Tpesel.Text))
                {
                    MessageBox.Show("dodano pomyślnie");
                }
                else
                {
                    MessageBox.Show("wystąpił błąd przy dodawaniu rekordów do bazy");
                }
            else
            {
                MessageBox.Show("błąd w danych");
            }
        }
    }
}
