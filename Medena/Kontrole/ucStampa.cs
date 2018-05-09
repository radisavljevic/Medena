using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medena.Model;

namespace Medena.Kontrole
{
    public partial class ucStampa : UserControl
    {
        private PanelGlavni panelMoj;

        public ucStampa()
        {
            InitializeComponent();
        }

        public void ucitajParametre(Artikal artikal, PanelGlavni panel)
        {
            panelMoj = panel;

            labelSifArt.Text = artikal.sifra.ToString();
            labelNazArt.Text = artikal.naziv.ToString();
            labelCenaArt.Text = artikal.cena.ToString();
            labelAkcijaArt.Text = artikal.cenaAkcija.ToString();          
        }

        private void buttonStampajArtikal_Click(object sender, EventArgs e)
        {
            clickStampajArtikal?.Invoke(this, e);
        }
        public event EventHandler clickStampajArtikal;
    }
}
