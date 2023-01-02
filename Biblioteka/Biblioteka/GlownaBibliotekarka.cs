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
    public partial class GlownaBibliotekarka : Form
    {
        public GlownaBibliotekarka()
        {
            InitializeComponent();
        }

        private void bDodaj_Click(object sender, EventArgs e)
        {
            var okno = new DodawanieWypozyczenia();
            okno.ShowDialog();
        }

        private void GlownaBibliotekarka_Load(object sender, EventArgs e)
        {
            var pol = new Polaczenie();

            var binding = new BindingList<DoOddania>(pol.wczytajKsiazkiB());
            var source = new BindingSource(binding, null);
            dtgKsiazki.DataSource = source;
        }

        private void bSzukaj_Click(object sender, EventArgs e)
        {
            var pol = new Polaczenie();

            if(string.IsNullOrEmpty(tImie.Text) && string.IsNullOrEmpty(tNazwisko.Text) && string.IsNullOrEmpty(tPesel.Text))
            {
                var binding = new BindingList<DoOddania>(pol.wczytajKsiazkiB());
                var source = new BindingSource(binding, null);
                dtgKsiazki.DataSource = source;                
            }
            else if (!string.IsNullOrEmpty(tImie.Text) && !string.IsNullOrEmpty(tNazwisko.Text) && !string.IsNullOrEmpty(tPesel.Text))
            {
                var binding = new BindingList<DoOddania>(pol.SzukajKsiazkiB(tImie.Text,tNazwisko.Text,tPesel.Text));
                var source = new BindingSource(binding, null);
                dtgKsiazki.DataSource = source;
            }
            else
            {
                MessageBox.Show("Wypełni puste pola");
            }
        }

        private void bZwrot_Click(object sender, EventArgs e)
        {
            var pol = new Polaczenie();
            string imie = dtgKsiazki.Rows[dtgKsiazki.SelectedCells[0].RowIndex].Cells["Imie"].Value.ToString();
            string nazwisko = dtgKsiazki.Rows[dtgKsiazki.SelectedCells[0].RowIndex].Cells["Nazwisko"].Value.ToString();
            string ksiazka = dtgKsiazki.Rows[dtgKsiazki.SelectedCells[0].RowIndex].Cells["Ksiazka"].Value.ToString();
            string pesel = dtgKsiazki.Rows[dtgKsiazki.SelectedCells[0].RowIndex].Cells["Pesel"].Value.ToString();

            if(pol.zwrot(imie, nazwisko, pesel, ksiazka))
            {
                MessageBox.Show("Zwrócono pomyślnie");
            }
            else
            {
                MessageBox.Show("Błąd w zwracaniu");
            }
            var binding = new BindingList<DoOddania>(pol.wczytajKsiazkiB());
            var source = new BindingSource(binding, null);
            dtgKsiazki.DataSource = source;
        }
    }
}
