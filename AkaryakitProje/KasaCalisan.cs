using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class KasaCalisan:IKasaCalisani
    {
        public Calisan Calisan { get; set; }
        public Kasa Kasa1 { get; set; }

        public KasaCalisan(Calisan calisan,Kasa kasa)
        {
            this.Calisan = calisan;
            this.Kasa1 = kasa;
            this.Calisan.Konum = kasa;
        }



    }
}
