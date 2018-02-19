using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class VásároltZene : Film, ILejátszható
    {
        public new string Stílus
        {
            get { return base.Stílus; }
            set { base.Stílus = value; }
        }
        public new int SzerzőiJogdíj
        {
            get { return base.SzerzőiJogdíj; }
            set { base.SzerzőiJogdíj = value; }
        }
        public new int Hossz
        {
            get { return base.Hossz; }
            set { base.Hossz = value; }
        }

        public VásároltZene(string cím, int ár, int hossz, string stilus)
            : base(cím, ár, hossz, stilus) 
        {

        }

        public override string ToString()
        {
            return "Cím: " + Cím + " ár: " + SzerzőiJogdíj + " hossz: " + Hossz + " stílus: " + Stílus;
        }
    }
}
