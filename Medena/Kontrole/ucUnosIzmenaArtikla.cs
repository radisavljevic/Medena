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
    public partial class ucUnosIzmenaArtikla : UserControl
    {
        private bool updateYesNo;
        private PanelGlavni panelMoj;


        public ucUnosIzmenaArtikla(bool update) : this()
        {
            updateYesNo = update;
        }

        public ucUnosIzmenaArtikla()
        {
            InitializeComponent();
            textBoxId.ReadOnly = true;
        }

        public void ucitajParemetre(Artikal artikal, PanelGlavni panel)
        {
            panelMoj = panel;
            if (updateYesNo)
            {
                textBoxId.Text = artikal.id.ToString();
                textBoxSifra.Text = artikal.sifra.ToString();
                textBoxNaziv.Text = artikal.naziv.ToString();
                textBoxCena.Text = artikal.cena.ToString();
                textBoxAkcija.Text = artikal.cenaAkcija.ToString();
            }
        }

        public Artikal iscitajParemetre(Artikal artikal, PanelGlavni panel)
        {
            panelMoj = panel;
            //kada radimo update
            if (updateYesNo)
            {
                if (textBoxSifra.Text == "" || textBoxNaziv.Text == "" || textBoxCena.Text == "" ||
                textBoxId.Text == "")
                {
                    MessageBox.Show("Niste uneli tekst u obavezno polje!!!");
                    return null;
                }
                else
                {
                    artikal.id = Int32.Parse(textBoxId.Text);
                    artikal.sifra = Int32.Parse(textBoxSifra.Text);
                    artikal.naziv = textBoxNaziv.Text;
                    artikal.cena = Decimal.Parse(textBoxCena.Text);
                    if (textBoxAkcija.Text == "")
                    {
                        artikal.cenaAkcija = 0;
                    }
                    else
                    {
                        artikal.cenaAkcija = Decimal.Parse(textBoxAkcija.Text);
                    }


                }
            }
            //kada radimo upis
            else
            {
                if (textBoxSifra.Text == "" || textBoxNaziv.Text == "" || textBoxCena.Text == "")
                {
                    MessageBox.Show("Niste uneli tekst u obavezno polje!!!");
                    return null;
                }
                else
                {
                    artikal.sifra = Int32.Parse(textBoxSifra.Text);
                    artikal.naziv = textBoxNaziv.Text;
                    artikal.cena = Decimal.Parse(textBoxCena.Text);
                    if (textBoxAkcija.Text == "")
                    {
                        artikal.cenaAkcija = 0;
                    }
                    else
                    {
                        artikal.cenaAkcija = Decimal.Parse(textBoxAkcija.Text);
                    }


                }
            }
            return artikal;
        }

        public void ucitajParemetre(PanelGlavni panel)
        {
            panelMoj = panel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            clickUpisiIliUpdate?.Invoke(this, e);
        }
        public event EventHandler clickUpisiIliUpdate;

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            panelMoj.prikazeArtikleIzTabele();
        }
    }
}
