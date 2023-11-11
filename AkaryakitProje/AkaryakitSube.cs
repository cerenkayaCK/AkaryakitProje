using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class AkaryakitSube
    {

        public event EventHandler İstasyonMusteriGeldi;

        #region listeler

        Istasyonlar istiyonListesi = new Istasyonlar();
        Kasalar kasalarListesi = new Kasalar();
        Calisanlar calisanlarListesi = new Calisanlar();

        #endregion

        public int maxCalisanAdet { get; set; }
        public int maxIstasyonAdet { get; set; }
        public int maxKasaAdet { get; set; } 

        void IstasyonAc()
        {
            if (istiyonListesi.Count < maxIstasyonAdet)
            {
                Istasyon istasyon = new Istasyon();
                istiyonListesi.Add(istasyon);
            }


        }

        void KasaAc()
        {
            if (kasalarListesi.Count < maxKasaAdet)
            {
                Kasa kasa = new Kasa();
                kasalarListesi.Add(kasa);
            }
        }

        void CalisanaKonumAta(Calisan calisan,Konum konum)
        {
            try
            {
                konum.CalisanEkle(calisan);
                calisanlarListesi.Remove(calisan);
            }
            catch (Exception)
            {

                throw new Exception();
            }

        }






    }
}
