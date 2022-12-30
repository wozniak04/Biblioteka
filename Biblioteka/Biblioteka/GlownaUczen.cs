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
    public partial class GlownaUczen : Form
    {
        private string Pesel;
        public GlownaUczen(string pesel)
        {
            InitializeComponent();
            this.Pesel = pesel;
        }

        private void GlownaUczen_Load(object sender, EventArgs e)
        {
            var pol = new Polaczenie();
            var binding = new BindingList<Ksiazki>(pol.wczytajKsiazkiU(this.Pesel));
            var source = new BindingSource(binding, null);
            dtgKsiazki.DataSource = source;
        }
    }
}
