using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medena.Kontrole
{
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
        }

        private void buttonPrikaziArtikle_Click(object sender, EventArgs e)
        {
            ClickPrikaziArtikle?.Invoke(this, e);
        }
        public event EventHandler ClickPrikaziArtikle;

        private void buttonDodajNovi_Click(object sender, EventArgs e)
        {
            ClickDodajNoviArtikal?.Invoke(this, e);
        }
        public event EventHandler ClickDodajNoviArtikal;

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            ClickIzmeniArtikal?.Invoke(this, e);
        }
        public event EventHandler ClickIzmeniArtikal;

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            ClickObrisiArtikal?.Invoke(this, e);
        }
        public event EventHandler ClickObrisiArtikal;

        private void buttonStampaj_Click(object sender, EventArgs e)
        {
            ClickStampaj?.Invoke(this, e);
        }
        public event EventHandler ClickStampaj;
    }
}
