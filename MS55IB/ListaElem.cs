using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class ListaElem<T>
    {
        private T érték;

        public T Érték
        {
            get { return érték; }
            set { érték = value; }
        }
        private ListaElem<T> következő;

        public ListaElem<T> Következő
        {
            get { return következő; }
            set { következő = value; }
        }
        public ListaElem(T érték)
        {
            this.érték = érték;
            this.következő = null;
        }
    }
}
