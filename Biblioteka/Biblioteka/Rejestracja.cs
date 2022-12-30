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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Brej_Click(object sender, EventArgs e)
        {
            var pol = new Polaczenie();
            string rola= tCzy.Checked? "U":"B";

            if (string.IsNullOrEmpty(tImie.Text) && string.IsNullOrEmpty(tNazwisko.Text) && string.IsNullOrEmpty(tNazwa.Text) && string.IsNullOrEmpty(tHaslo.Text) && string.IsNullOrEmpty(tPesel.Text))
            {
                MessageBox.Show("błąd w danych");

            }
            else
            {
                if (pol.rejestracja(tImie.Text, tNazwisko.Text, tNazwa.Text, tHaslo.Text, tPesel.Text, rola))
                    MessageBox.Show("dodano użytkownika poprawnie");
                else
                    MessageBox.Show("błąd");
            }
            
        }
    }
}
