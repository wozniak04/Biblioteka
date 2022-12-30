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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            var pol = new Polaczenie();
            if (pol.log(tNazwa.Text,tHaslo.Text).Equals("B")) 
            {
                var okno = new GlownaBibliotekarka();
                this.Hide();
                okno.ShowDialog();
                this.Close(); 
            }else if (pol.log(tNazwa.Text, tHaslo.Text).Equals("U"))
            {
                var okno = new GlownaUczen(pol.GetPesel(tNazwa.Text, tHaslo.Text));
                this.Hide();
                okno.ShowDialog();
                this.Close();
            }
            else
            {
                lBlad.Visible = true;
            }
        }

        private void bRej_Click(object sender, EventArgs e)
        {
            var okno = new Rejestracja();
            
            okno.ShowDialog();
            
        }
    }
}
