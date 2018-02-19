using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class lista
    {
        Dictionary<string, List<ILejátszható>> adatok = new Dictionary<string, List<ILejátszható>>();
        TartalomÖsszeállító t = new TartalomÖsszeállító();
        
        internal Dictionary<string, List<ILejátszható>> Adatok
        {
            get { return adatok; }
            set { adatok = value; }
        }
        public lista(LáncoltLista<ILejátszható> tartalom, string[] támogatott)
        {
            adatok.Add("Rock", new List<ILejátszható>());

            foreach (ILejátszható i in t.Tartalom)
            {
                switch (i.Stílus)
                {
                    case "Rock": adatok["Rock"].Add(i); break;

                }
            }
            
        }
    }
}
