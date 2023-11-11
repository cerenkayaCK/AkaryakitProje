using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProje
{
    public class Kasalar : ICollection<Kasa>
    {
        private List<Kasa> kasaListesi = new List<Kasa>();

        public void Add(Kasa item)
        {
            kasaListesi.Add(item);
        }

        public void Clear()
        {
            kasaListesi.Clear();
        }

        public bool Contains(Kasa item)
        {
            return kasaListesi.Contains(item);
        }

        public void CopyTo(Kasa[] array, int arrayIndex)
        {
            kasaListesi.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return kasaListesi.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Kasa item)
        {
            return kasaListesi.Remove(item);
        }

        public IEnumerator<Kasa> GetEnumerator()
        {
            return kasaListesi.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
