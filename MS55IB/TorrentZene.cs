using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class TorrentZene : ILejátszható
    {
        public int SzerzőiJogdíj
        {
            get { throw new NotImplementedException(); }
            set { SzerzőiJogdíj = 0; }
        }
        private int hossz;

        private string stílus;

        public string Stílus
        {
            get { return stílus; }
            set { stílus = value; }
        }

        public int Hossz
        {
            get { return hossz; }
            set { hossz = value; }
        }
        private string cím;

        //public string Cím
        //{
        //    get { return cím; }
        //    set { cím = value; }
        //}

        public TorrentZene(string cím, int hossz, string stilus)
        {
            this.stílus = stilus;
            this.cím = cím;
            this.hossz = hossz;

        }
        public override string ToString()
        {
            return "Cím: " + cím + " hossz: " + hossz + " stílus: " + stílus;
        }
    }
}
