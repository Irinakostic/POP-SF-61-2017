﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_61_2017.Model
{
    public class Akcija
    {
        public int Id { get; set; }
            public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public bool Obrisan { get; set; } 
    }
}
