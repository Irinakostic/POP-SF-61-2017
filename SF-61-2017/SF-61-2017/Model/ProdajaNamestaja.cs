using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_61_2017.Model
{
    class ProdajaNamestaja
    {
        public int Id { get; set; }
       public List<Namestaja> NamestajZaProdaju { get; set; }
        public DateTime DatumProdaje { get; set; }
        public string BrojRacuna
            public List <DodatnaUsluga> DodatneUsluge { get; set; }
        public double PDV { get; set; }
        public double Cena { get; set; }
    }
}
