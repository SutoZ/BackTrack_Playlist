using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class Film : ILejátszható
    {
        private string stílus;

        public string Stílus
        {
            get { return stílus; }
            set { stílus = value; }
        }


        private string cím;
        private int ár;
        private int hossz;
        public string Cím
        {
            get { return cím; }
            set { cím = value; }
        }

        public Film(string cím, int ár, int hossz, string stilus)
        {
            this.cím = cím;
            SzerzőiJogdíj = ár;
            Hossz = hossz;
            this.stílus = stilus;
        }

        public int SzerzőiJogdíj
        {
            get { return ár; }
            set { ár = value; }
        }

        public int Hossz
        {
            get { return hossz; }
            set { hossz = value; }
        }
        public override string ToString()
        {
            return "Cím: " + Cím + " Ár: " + SzerzőiJogdíj + " Hossz: " + Hossz + " Stílus: " + Stílus;
        }
    }
}
