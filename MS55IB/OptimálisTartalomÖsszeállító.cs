using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class OptimálisTartalomÖsszeállító
    {
        LáncoltLista<ILejátszható> tartalom;

        public LáncoltLista<ILejátszható> Tartalom
        {
            get { return tartalom; }
            set { tartalom = value; }
        }
        public OptimálisTartalomÖsszeállító(LáncoltLista<ILejátszható> tartalom)
        {
            this.tartalom = tartalom;
        }
        public bool MegoldasKereses()
        {
            return false;
        }
        private void Backtrack()
        {
 
        }
    }
}
