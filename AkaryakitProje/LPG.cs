using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    internal class LPG : Yakit
    {
        public LPG()
        {
            KalanMiktar = Miktar;            
        }
        public double Miktar { get; set; } = 1000;
        public override double Fiyat { get; set; } = 18;
        public double KalanMiktar { get; set; }
    }

}
