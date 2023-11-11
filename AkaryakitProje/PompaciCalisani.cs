using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class PompaciCalisani : IPompaciCalisan
    {
    
        public Calisan Pompaci { get; set; }

        public Istasyon _istasyon { get; set; }

        public PompaciCalisani(Calisan calisan,Istasyon istasyon)
        {
            _istasyon = istasyon;
            Pompaci = calisan;
            Pompaci.Konum = istasyon;
        }
    }
}
