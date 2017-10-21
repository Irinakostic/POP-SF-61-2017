using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_61_2017.Model
{
   public class namestaj
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public double Cena { get; set; }
        public int KolicinaUMagacinu { get; set; }
        public Akcija Akcija { get; set; }
        public TipNamestaja { get; set; }
}
}
