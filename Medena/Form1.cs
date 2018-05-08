using Medena.DAO;
using Medena.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArtikalDAO artikalDAO = new ArtikalDAO();
            List<Artikal> listaArtikala = artikalDAO.dajArtikle();

            foreach(Artikal art in listaArtikala)
            {
                Console.WriteLine(art.ToString());
            }
            
        }
       
    }
}
