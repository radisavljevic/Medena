using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Configuration;
using System.Windows.Forms;
using Medena.Model;
using System.Data;

namespace Medena.DAO
{
    class ArtikalDAO
    {
        private string konekcija;

        public ArtikalDAO()
        {
            konekcija = ConfigurationManager.ConnectionStrings["ConnectionString1"].ToString();
        }


        public List<Artikal> dajArtikle()
        {

            try
            {
                using (SqlCeConnection cn = new SqlCeConnection(konekcija))
                {
                    SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Artikli", cn);
                    cn.Open();
                    List<Artikal> lista = new List<Artikal>();
                    SqlCeDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Artikal artikal = new Artikal();
                        artikal.id = Convert.ToInt32(reader["id"]);
                        artikal.sifra = Convert.ToInt32(reader["sifra"]);
                        artikal.naziv = reader["naziv"].ToString();
                        artikal.cena = Convert.ToDecimal(reader["cena"]);
                        if (!(reader["cena_akcija"] is DBNull))
                        {
                            artikal.cenaAkcija = Convert.ToDecimal(reader["cena_akcija"]);
                        }
                        else
                        {
                            Console.WriteLine("Cena Akcija je null " + artikal.ToString());
                        }
                        lista.Add(artikal);
                    }
                    return lista;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.ToString());
                Console.WriteLine("nema tabele!!!  " + ex.Message);
                return null;

            }

        }

        public DataTable dajTabeluSaArtiklima()
        {
            try
            {
                using (SqlCeConnection cn = new SqlCeConnection(konekcija))
                {
                    SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Artikli", cn);
                    SqlCeDataAdapter da = new SqlCeDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);                   
                
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("nema tabele!!!  " + ex.Message);
                return new DataTable();
            }
        }

        public void obrisiArtikal(int id)
        {
            try
            {
                using (SqlCeConnection cn = new SqlCeConnection(konekcija))
                {
                    SqlCeCommand cmd = new SqlCeCommand("delete from Artikli where id=@id", cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Number of rows deleted: " + rows);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("nema tabele!!!  " + ex.Message);
                MessageBox.Show("Greska pri brisanju! ");
            }
        }

        public void updateArtikal(Artikal artikal)
        {
            try
            {
                using (SqlCeConnection cn = new SqlCeConnection(konekcija))
                {
                 
                        SqlCeCommand cmd = new SqlCeCommand("update Artikli set sifra=@sifra, naziv=@naziv, cena=@cena, cena_akcija=@cenaAkcija where id = @id", cn);
                        cmd.Parameters.AddWithValue("@id", artikal.id);
                        cmd.Parameters.AddWithValue("@naziv", artikal.naziv);
                        cmd.Parameters.AddWithValue("@sifra", artikal.sifra);
                        cmd.Parameters.AddWithValue("@cena", artikal.cena);
                        cmd.Parameters.AddWithValue("@cenaAkcija", artikal.cenaAkcija);
                        cn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        MessageBox.Show("Number of rows updated: " + rows);
                    
                  
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("nema tabele!!!  " + ex.Message);
                MessageBox.Show("Greska pri upisu! ");
            }
        }


        public void upisiArtikal(Artikal artikal)
        {
            try
            {
                using (SqlCeConnection cn = new SqlCeConnection(konekcija))
                {
                    SqlCeCommand cmd = new SqlCeCommand("insert into Artikli (sifra,naziv,cena,cena_akcija) values (@sifra,@naziv,@cena,@akcija)", cn);

                    cmd.Parameters.AddWithValue("@sifra", artikal.sifra);
                    cmd.Parameters.AddWithValue("@naziv", artikal.naziv);
                    cmd.Parameters.AddWithValue("@cena", artikal.cena);
                    cmd.Parameters.AddWithValue("@akcija", artikal.cenaAkcija);

                    cn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Number of rows inserted: " + rows + "\n " + "Uspesno dodat artikal!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("nema tabele!!!  " + ex.Message);
                MessageBox.Show("Greska pri upisu! ");
            }

        }

    }

}


