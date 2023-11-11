using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    internal class Benzin:Yakit
    {
        public Benzin()
        {
            KalanMiktar = Miktar;

        }
        public double Miktar { get; set; } = 1000;
        public override double Fiyat { get; set; } = 35;
        public double KalanMiktar { get; set; }


    }
}
