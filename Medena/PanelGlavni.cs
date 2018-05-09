using Medena.DAO;
using Medena.Kontrole;
using Medena.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medena
{
    public class PanelGlavni
    {
        Form1 form1;
        ucGrid ucGrid;
        ucUnosIzmenaArtikla ucUnosIzmenaArtikla;
        ucStampa ucStampa;
        ucMenu ucMenu = new ucMenu();
        ucTelo ucTelo = new ucTelo();
        FormWindowState fws = new FormWindowState();

        public void ucitajFormu(Form1 forma)
        {
            form1 = forma;
            fws = FormWindowState.Normal;

            ucTelo.Dock = DockStyle.Fill;
            ucMenu.Dock = DockStyle.Left;


            ucMenu.ClickPrikaziArtikle += new EventHandler(eClickPrikaziArtikle);
            ucMenu.ClickDodajNoviArtikal += new EventHandler(eClickDodajNoviArtikal);
            ucMenu.ClickIzmeniArtikal += new EventHandler(eClickIzmeniArtikal);
            ucMenu.ClickObrisiArtikal += new EventHandler(eClickObrisiArtikal);
            ucMenu.ClickStampaj += new EventHandler(eClickStampaj);

            form1.Controls.Add(ucTelo);
            form1.Controls.Add(ucMenu);

        }


        private void eClickPrikaziArtikle(object sender, EventArgs e)
        {
            prikazeArtikleIzTabele();
        }

        private void eClickDodajNoviArtikal(object sender, EventArgs e)
        {
            ucUnosIzmenaArtikla = new ucUnosIzmenaArtikla();
            ucUnosIzmenaArtikla.ucitajParemetre(this);
            ucUnosIzmenaArtikla.clickUpisiIliUpdate += new EventHandler(eClickUpisiArtikal);
            ucUnosIzmenaArtikla.Dock = DockStyle.Fill;
            ucTelo.Controls.Add(ucUnosIzmenaArtikla);
            ucUnosIzmenaArtikla.BringToFront();

        }

        private void eClickIzmeniArtikal(object sender, EventArgs e)
        {
            if (ucGrid != null)
            {
                Artikal artikal = ucGrid.dajObelezeniRed();
                if (artikal != null)
                {
                    ucUnosIzmenaArtikla = new ucUnosIzmenaArtikla(true);
                    ucUnosIzmenaArtikla.ucitajParemetre(artikal, this);
                    ucUnosIzmenaArtikla.clickUpisiIliUpdate += new EventHandler(eClickUpdateArtikal);
                    ucUnosIzmenaArtikla.Dock = DockStyle.Fill;
                    ucTelo.Controls.Add(ucUnosIzmenaArtikla);
                    ucUnosIzmenaArtikla.BringToFront();
                }
                else
                {
                    MessageBox.Show("Niste obelezili red!!!");
                }
            }
            else
            {
                MessageBox.Show("Tabela nije ucitana!!!");
            }


        }



        private void eClickObrisiArtikal(object sender, EventArgs e)
        {
            Artikal artikal = ucGrid.dajObelezeniRed();
            if (artikal != null)
            {
                ArtikalDAO dao = new ArtikalDAO();
                dao.obrisiArtikal(artikal.id);
                prikazeArtikleIzTabele();
            }
            else
            {
                MessageBox.Show("Niste obelezili red!!!");
            }
        }

        private void eClickStampaj(object sender, EventArgs e)
        {
            if (ucGrid != null)
            {
                Artikal artikal = ucGrid.dajObelezeniRed();
                if (artikal != null)
                {
                    ucStampa = new ucStampa();
                    ucStampa.ucitajParametre(artikal, this);
                    ucStampa.clickStampajArtikal += new EventHandler(eclickStampajArtikal);
                    ucStampa.Dock = DockStyle.Fill;
                    ucTelo.Controls.Add(ucStampa);
                    ucStampa.BringToFront();
                }
                else
                {
                    //stampaj sve
                    MessageBox.Show("Niste obelezili red!!!");
                }
            }
            else
            {
                MessageBox.Show("Tabela nije ucitana!!!");
            }
        }

        private void eclickStampajArtikal(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void prikazeArtikleIzTabele()
        {
            ArtikalDAO artikalDAO = new ArtikalDAO();
            ucGrid = new ucGrid();
            DataTable table = artikalDAO.dajTabeluSaArtiklima();

            ucGrid.ucitajGrid(table);
            ucGrid.Dock = DockStyle.Fill;
            ucTelo.Controls.Add(ucGrid);
            ucGrid.BringToFront();

            List<Artikal> listaArt = artikalDAO.dajArtikle();
            Console.WriteLine("Artikli:" + listaArt.Count);
        }

        private void eClickUpdateArtikal(object sender, EventArgs e)
        {
            ArtikalDAO artikalDao = new ArtikalDAO();
            Artikal artikal = new Artikal();
            artikal = ucUnosIzmenaArtikla.iscitajParemetre(artikal, this);
            if(artikal != null)
            {
                artikalDao.updateArtikal(artikal);
                prikazeArtikleIzTabele();
            }
                     
        }

        private void eClickUpisiArtikal(object sender, EventArgs e)
        {
            ArtikalDAO artikalDao = new ArtikalDAO();
            Artikal artikal = new Artikal();
            artikal = ucUnosIzmenaArtikla.iscitajParemetre(artikal, this);
            if (artikal != null)
            {
                //MessageBox.Show(artikal.ToString());
                artikalDao.upisiArtikal(artikal);
                prikazeArtikleIzTabele();
            }
        }


    }
}
