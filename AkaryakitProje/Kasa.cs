using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class Kasa : Konum
    {
        public KasaCalisan _kasaCalisani { get; set; }

        public override void CalisanEkle(Calisan calisan)
        {
            KasaCalisan kasaCalisani = new KasaCalisan(calisan,this);
            _kasaCalisani = kasaCalisani;
        }
    }
}
