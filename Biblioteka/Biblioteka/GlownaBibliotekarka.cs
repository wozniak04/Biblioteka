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
        private string Nazwa;
        public GlownaBibliotekarka(string nazwa)
        {
            InitializeComponent();
            this.Nazwa = nazwa;
        }

        private void bZwrot_Click(object sender, EventArgs e)
        {

        }

        private void bDodaj_Click(object sender, EventArgs e)
        {
            var okno = new DodawanieWypozyczenia();
            okno.ShowDialog();
        }
    }
}
