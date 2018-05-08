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
    public partial class ucGrid : UserControl
    {
        public ucGrid()
        {
            InitializeComponent();
        }
        public void ucitajGrid(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        public Artikal dajObelezeniRed()
        {
            // DataGridViewRow row = dataGridView1.CurrentRow;
            Artikal artikal = new Artikal();
            Console.WriteLine("OBELEZENI REDOVI: " + dataGridView1.SelectedRows.Count + "  " + dataGridView1.CurrentRow);
            if (dataGridView1.SelectedRows.Count != 0)
            {

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                artikal.id = (int)row.Cells["id"].Value;
                artikal.sifra = (int)row.Cells["sifra"].Value;
                artikal.naziv = (string)row.Cells["naziv"].Value;
                artikal.cena = (decimal)row.Cells["cena"].Value;
                if (row.Cells["cena_akcija"].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells["cena_akcija"].Value.ToString()))
                {
                    Console.WriteLine("cena akcija: nula!");
                }
                else
                {
                    artikal.cenaAkcija = (decimal)row.Cells["cena_akcija"].Value;
                    Console.WriteLine("cena akcija: " + row.Cells["cena_akcija"].Value.ToString());
                }

                return artikal;
            }
            else
            {
                return null;
            }

        }

    }
}
