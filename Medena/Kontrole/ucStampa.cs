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
            ucTelo ucTelo = panelMoj.dajTelo();
            Panel panel = panelZaStampu;
            //this.Controls.Add(panel);
            Graphics grp = this.CreateGraphics();
            //Size formSize = this.ClientSize;
            //bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            bitmap = new Bitmap(this.Size.Width, this.Size.Height, grp);
            grp = Graphics.FromImage(bitmap);
            
            //Point panelLocation = PointToScreen(panel.Location);
            //grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            grp.CopyFromScreen(ucTelo.Location.X, ucTelo.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            //clickStampajArtikal?.Invoke(this, e);
        }
        //public event EventHandler clickStampajArtikal;

        Bitmap bitmap;
             
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bitmap = Properties.Resources.nedeljkovic_logo_4;
            //Image image = bitmap;
            //e.Graphics.DrawImage(image, 25, 25, image.Width, image.Height);
            //e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            e.Graphics.DrawImage(bitmap, 0, 0);
            //e.Graphics.DrawString("Šifra artikla: " + labelSifArt.Text + "\nNaziv artikla: " + labelNazArt.Text,
            //    new Font("Ärial", 30, FontStyle.Regular), Brushes.Black,
            //    new Point(25,100));

            //e.Graphics.DrawString("Cena: " + labelCenaArt.Text,
            //  new Font("Ärial", 20, FontStyle.Regular), Brushes.Black,
            //  new Point(25, 500));

        }
    }
}
