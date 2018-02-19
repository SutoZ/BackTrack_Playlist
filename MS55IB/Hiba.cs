using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class Hiba : ApplicationException
    {
        public Hiba(string szoveg)
            : base(szoveg)
        {
        }
    }
}
