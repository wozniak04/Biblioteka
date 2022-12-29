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
            string nazwa = tNazwa.Text.ToString();
            string haslo = tHaslo.Text.ToString();
            GlownaUczen okno = new GlownaUczen(nazwa);
            okno.ShowDialog();
            
        }
    }
}
