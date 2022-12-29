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
        private string Nazwa;
        public GlownaUczen(string nazwa)
        {
            InitializeComponent();
            this.Nazwa = nazwa;
        }

        private void GlownaUczen_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaDataSet.Wypozyczone' . Możesz go przenieść lub usunąć.
            this.wypozyczoneTableAdapter.Fill(this.bazaDataSet.Wypozyczone);

        }
    }
}
