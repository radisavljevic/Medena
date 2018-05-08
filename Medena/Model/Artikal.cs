using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medena.Model
{
    public class Artikal
    {
        public int id { get; set; }
        public int sifra { get; set; }
        public string naziv { get; set; }
        public decimal cena { get; set; }
        public decimal cenaAkcija { get; set; }

        public override string ToString()
        {
            return "ID: " + id + " ,NAZIV: " + naziv + " CENA: " + cena;
        }
    }
 
}

