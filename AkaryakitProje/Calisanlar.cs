using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class Calisanlar : ICollection<Calisan>
    {
        private List<Calisan> calisanListesi = new List<Calisan>();

        public void Add(Calisan item)
        {
            calisanListesi.Add(item);
        }

        public void Clear()
        {
            calisanListesi.Clear();
        }

        public bool Contains(Calisan item)
        {
            return calisanListesi.Contains(item);
        }

        public void CopyTo(Calisan[] array, int arrayIndex)
        {
            calisanListesi.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return calisanListesi.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Calisan item)
        {
            return calisanListesi.Remove(item);
        }

        public IEnumerator<Calisan> GetEnumerator()
        {
            return calisanListesi.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
