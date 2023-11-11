using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class Istasyonlar : ICollection<Istasyon>
    {
        private List<Istasyon> istasyonListesi = new List<Istasyon>();

        public void Add(Istasyon item)
        {
            istasyonListesi.Add(item);
        }

        public void Clear()
        {
            istasyonListesi.Clear();
        }

        public bool Contains(Istasyon item)
        {
            return istasyonListesi.Contains(item);
        }

        public void CopyTo(Istasyon[] array, int arrayIndex)
        {
            istasyonListesi.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return istasyonListesi.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Istasyon item)
        {
            return istasyonListesi.Remove(item);
        }

        public IEnumerator<Istasyon> GetEnumerator()
        {
            return istasyonListesi.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }



}
