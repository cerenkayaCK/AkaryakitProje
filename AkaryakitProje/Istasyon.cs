using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class Istasyon : Konum
    {
        
        
        public PompaciCalisani _pompaciCalisan { get; set; }
        public override void CalisanEkle(Calisan calisan)
        {
            //PompaciCalisani pompaciCalisani = new PompaciCalisani(calisan, this);
            _pompaciCalisan = new PompaciCalisani(calisan, this);
        }
    }
}
