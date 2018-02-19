using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class LáncoltListaEnumerátor<T> :IEnumerator<T>
    {
        ListaElem<T> aktualis;
        ListaElem<T> elso;

        public LáncoltListaEnumerátor(ListaElem<T> elsoElem)
        {
            this.elso = elsoElem;
            aktualis = null;
        }
        public T Current
        {
            get { return (T)aktualis.Érték; }
        }

        public void Dispose()
        {
            elso = null;
            aktualis = null;
        }

        object System.Collections.IEnumerator.Current
        {
            get { return this.Current; }
        }

        public bool MoveNext()
        {
            if (aktualis==null)
            {
                aktualis = elso;
            }
            else
            {
                aktualis = aktualis.Következő;
            }
            return aktualis != null;
        }

        public void Reset()
        {
            aktualis = null;
        }
    }
}
