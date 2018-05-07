using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Configuration;
using System.Windows.Forms;

namespace Medena.DB
{
    class ConnectionClass
    {
        //SqlCeCommand cmd;

        public static void dajArtikle()
        {
            try
            {
                using (SqlCeConnection cn = new SqlCeConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ToString()))
                {
                    SqlCeCommand cmd = new SqlCeCommand("SELECT naziv FROM Artikli", cn);
                    cn.Open();
                    SqlCeDataReader reader1 = cmd.ExecuteReader();

                    while (reader1.Read())
                    {
                        MessageBox.Show("Result :" + reader1[0]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.ToString());

            }

        }




    }

}


