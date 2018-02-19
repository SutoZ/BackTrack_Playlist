using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    interface ILejátszható
    {
        int SzerzőiJogdíj { get; set; }      //számlejátszásonként ennyit kell fizetni.
        int Hossz { get; set; }
        string Stílus { get;set; }
    }
}
